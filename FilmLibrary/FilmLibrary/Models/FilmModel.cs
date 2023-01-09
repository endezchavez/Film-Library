using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Models
{
    public class FilmModel
    {
        /// <summary>
        /// The unique identifier for the film
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The film's title
        /// </summary>
        public string Title { get; set; } = "";
        /// <summary>
        /// A description of what the film is about
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// The date on which the film was released
        /// </summary>
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// The film's rating from 1-5 
        /// </summary>
        public decimal Rating { get; set; }

        public FilmModel()
        {

        }

        public FilmModel(string title, string description, DateTime releaseDate, string rating)
        {
            Title = title;
            Description = description;
            //ReleaseDate = DateOnly.FromDateTime(releaseDate.Date);
            ReleaseDate = releaseDate;

            decimal ratingValue = 0;
            decimal.TryParse(rating, out ratingValue);
            Rating = ratingValue;
        }
    }
}
