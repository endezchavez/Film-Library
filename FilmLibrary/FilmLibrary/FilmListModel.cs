using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
    public class FilmListModel
    {
        /// <summary>
        /// A list of films stored in the film library
        /// </summary>
        public List<FilmModel> FilmList { get; set; } = new List<FilmModel>();
    }
}
