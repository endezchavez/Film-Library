using FilmLibrary.Models;
using IMDbApiLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.DataAccess
{
    public class IMDBConnector : IDataConnection
    {
        public FilmModel CreateFilm(FilmModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteFilm(FilmModel model)
        {
            throw new NotImplementedException();
        }

        public async List<FilmModel> GetFilm_All()
        {
            List<FilmModel> result = new List<FilmModel>();

            var api = new ApiLib("k_12345678");
            var apiResult = await api.SearchMovieAsync("");

            foreach(var item in apiResult.Results)
            {
                var titleData = await api.TitleAsync(item.Id);
                var descriptionData = await api.WikipediaAsync(item.Id, IMDbApiLib.Models.Language.uk);
                var ratingData = await api.RatingsAsync(item.Id);

                FilmModel model = new FilmModel(titleData.FullTitle, descriptionData.PlotFull.PlainText, DateTime.Now, "0");

                result.Add(model);
            }

            return result;

        }

        public List<FilmModel> GetFilm_ByTitle(string input)
        {
            throw new NotImplementedException();
        }

        public void UpdateFilm(FilmModel model)
        {
            throw new NotImplementedException();
        }
    }
}
