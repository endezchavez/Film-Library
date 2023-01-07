using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO: Make the CreateFilm method actually save to a text file
        /// <summary>
        /// Saves a film to a text file
        /// </summary>
        /// <param name="model">The films information</param>
        /// <returns>The films information, including the unique identifier</returns>
        public FilmModel CreateFilm(FilmModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
