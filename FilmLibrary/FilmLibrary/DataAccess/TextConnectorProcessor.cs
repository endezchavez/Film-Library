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
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

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

        public static void SaveToFilmFile(this List<FilmModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (FilmModel model in models)
            {
                lines.Add($"{ model.Id },\"{ model.Title }\",\"{ model.Description }\",{ model.ReleaseDate },{ model.Rating }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

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
