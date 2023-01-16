using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.DataAccess.TextHelpers;
using FilmLibrary.Models;

namespace FilmLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string FilmsFile = "FilmModels.csv";
        /// <summary>
        /// Saves a film to a text file
        /// </summary>
        /// <param name="model">The films information</param>
        /// <returns>The films information, including the unique identifier</returns>
        public FilmModel CreateFilm(FilmModel model)
        {
            // Load the text file and convert the text to a List<FilmModel>
            List<FilmModel> films = FilmsFile.FullFilePath().LoadFile().ConvertToFilmModels();

            // Find the max ID
            int currentId = 1;

            if(films.Count > 0)
            {
                currentId = films.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new rcord with the new ID (max + 1)
            films.Add(model);

            // Convert the films to a List<string>
            // Save the list List<string> to the text file
            films.SaveToFilmFile(FilmsFile);

            return model;
        }

        /// <summary>
        /// Updates a given film's data in the text file
        /// </summary>
        /// <param name="model">The film to be updated</param>
        public void UpdateFilm(FilmModel model)
        {
            // Load the text file and convert the text to a List<FilmModel>
            List<FilmModel> films = FilmsFile.FullFilePath().LoadFile().ConvertToFilmModels();

            //TODO: Check to make sure the ID exists
            foreach (FilmModel film in films)
            {
                if(film.Id == model.Id)
                {
                    film.Title = model.Title;
                    film.Description = model.Description;
                    film.ReleaseDate = model.ReleaseDate;
                    film.Rating = model.Rating;

                    films.SaveToFilmFile(FilmsFile);
                }
            }
        }

        /// <summary>
        /// Get's all films from a text file
        /// </summary>
        /// <returns>A list of all films in the text file</returns>
        public List<FilmModel> GetFilm_All()
        {
            return FilmsFile.FullFilePath().LoadFile().ConvertToFilmModels();
        }

        /// <summary>
        /// Deletes a given film from the text file
        /// </summary>
        /// <param name="model">The film to be deleted</param>
        public void DeleteFilm(FilmModel model)
        {
            List<FilmModel> films = FilmsFile.FullFilePath().LoadFile().ConvertToFilmModels();

            for (int i = films.Count - 1; i >= 0; i--)
            {
                if (films[i].Id == model.Id)
                {
                    films.RemoveAt(i);

                    films.SaveToFilmFile(FilmsFile);
                }
            }
        }

        /// <summary>
        /// Get's all films that match a given title
        /// </summary>
        /// <param name="input">The title we are searching for</param>
        /// <returns>A list of all films that match the search string</returns>
        public List<FilmModel> GetFilm_ByTitle(string input)
        {
            List<FilmModel> allFilms = FilmsFile.FullFilePath().LoadFile().ConvertToFilmModels();
            return allFilms.Where(x => x.Title.Contains(input, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
