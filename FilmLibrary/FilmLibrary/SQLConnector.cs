using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO: Make the CreateFilm method actually save to the database
        /// <summary>
        /// Saves a film to the database
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
