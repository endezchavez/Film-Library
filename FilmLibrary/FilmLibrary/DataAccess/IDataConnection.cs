using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.Models;

namespace FilmLibrary.DataAccess
{
    public interface IDataConnection
    {
        FilmModel CreateFilm(FilmModel model);
        List<FilmModel> GetFilm_All();
        List<FilmModel> GetFilm_ByTitle(string input);
        void UpdateFilm(FilmModel model);
        void DeleteFilm(FilmModel model);
    }
}
