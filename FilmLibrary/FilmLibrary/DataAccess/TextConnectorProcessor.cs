using FilmLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace FilmLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        /// <summary>
        /// An extension mehtod that get's the full file path given a fileName
        /// </summary>
        /// <param name="fileName">The file name</param>
        /// <returns>The full file path as a string</returns>
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }

        /// <summary>
        /// An extension method that get's all the text in a given file path
        /// </summary>
        /// <param name="file">The full file path</param>
        /// <returns>A list of all strings in the given file path</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// An extensions method that converts a list of strings into a list of FilmModels
        /// </summary>
        /// <param name="lines">A list of strings</param>
        /// <returns>A list of FilmModel's</returns>
        public static List<FilmModel> ConvertToFilmModels(this List<string> lines)
        {
            List<FilmModel> output = new List<FilmModel>();

            foreach (string line in lines)
            {
                //Ignore commas that are inside quotes
                string[] columns = line.SplitLines();

                FilmModel film = new FilmModel();

                film.Id = int.Parse(columns[0]);
                film.Title = columns[1];
                film.Description = columns[2];
                film.ReleaseDate = DateTime.Parse(columns[3]);
                film.Rating = decimal.Parse(columns[4]);

                output.Add(film);

            }

            return output;
        }

        /// <summary>
        /// An extension method that saves film data to a text file given a list of films and a file name
        /// </summary>
        /// <param name="models">The list of films that are to be saved</param>
        /// <param name="fileName">The file name</param>
        public static void SaveToFilmFile(this List<FilmModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (FilmModel model in models)
            {
                lines.Add($"{ model.Id },\"{ model.Title }\",\"{ model.Description }\",{ model.ReleaseDate },{ model.Rating }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /// <summary>
        /// An extension method that splits an entry of film data from a text file into an array of strings where each element is a single peice of film data
        /// </summary>
        /// <param name="line">The string to be split</param>
        /// <returns>An array of strings where each element is a single peice of film data</returns>
        public static string[] SplitLines(this string line)
        {
            List<string> result = new List<string>();
            StringBuilder currentStr = new StringBuilder("");
            bool inQuotes = false;
            foreach(Char c in line)
            {
                if (c == '\"')  //Quotes are closing or opening
                    inQuotes = !inQuotes;
                else if(c == ',')
                {
                    if (!inQuotes)  //If not in quotes, end current string, add it to result
                    {
                        result.Add(currentStr.ToString());
                        currentStr.Clear();
                    }
                    else
                    {
                        currentStr.Append(c);   //If in quotes, just add it
                    }
                }
                else
                {
                    currentStr.Append(c);   //Add any other character to current string
                }
            }
            result.Add(currentStr.ToString());
            return result.ToArray();    //Return array of all strings
        } 
    } 
}
