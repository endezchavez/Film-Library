using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class FilmModel
    {
        /// <summary>
        /// The unique identifier for the film
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The film's name
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// A description of what the film is about
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// The date on which the film was released
        /// </summary>
        public DateOnly ReleaseDate { get; set; }
        /// <summary>
        /// The film's rating from 1-5 
        /// </summary>
        public int Rating { get; set; }
    }
}
