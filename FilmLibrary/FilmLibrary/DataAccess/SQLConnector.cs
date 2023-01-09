using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using FilmLibrary.Models;

namespace FilmLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {

        private const string db = "Films";
        // TODO: Make the CreateFilm method actually save to the database
        /// <summary>
        /// Saves a film to the database
        /// </summary>
        /// <param name="model">The films information</param>
        /// <returns>The films information, including the unique identifier</returns>
        public FilmModel CreateFilm(FilmModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@title", model.Title);
                p.Add("@description", model.Description);
                p.Add("@releaseDate", model.ReleaseDate);
                p.Add("@rating", model.Rating);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spFilm_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model; 
            }
        }

        public List<FilmModel> GetFilm_All()
        {
            List<FilmModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<FilmModel>("dbo.sFilm_GetAll").ToList();
            }

            return output;
        }
    }
}
