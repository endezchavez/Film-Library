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

        /// <summary>
        /// Deletes a film from the database
        /// </summary>
        /// <param name="model">The given film to be deleted</param>
        public void DeleteFilm(FilmModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                
                connection.Execute("dbo.spFilm_Delete", p, commandType: CommandType.StoredProcedure);

            }
        }

        /// <summary>
        /// Gets all films from the databse
        /// </summary>
        /// <returns>A list of all films in the database</returns>
        public List<FilmModel> GetFilm_All()
        {
            List<FilmModel> output;
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<FilmModel>("dbo.spFilm_GetAll").ToList();
            }

            return output;
        }

        /// <summary>
        /// Get's all films that match a given title
        /// </summary>
        /// <param name="input">The title we are searching for</param>
        /// <returns>A list of all films that match the search string</returns>
        public List<FilmModel> GetFilm_ByTitle(string input)
        {
            List<FilmModel> output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@title", input);
                output = connection.Query<FilmModel>("dbo.spFilm_GetByTitle", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        /// <summary>
        /// Updates a film's data in the database
        /// </summary>
        /// <param name="model">The film that needs to be updated</param>
        public void UpdateFilm(FilmModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@title", model.Title);
                p.Add("@description", model.Description);
                p.Add("@releaseDate", model.ReleaseDate);
                p.Add("@rating", model.Rating);
                
                connection.Execute("dbo.spFilm_Update", p, commandType: CommandType.StoredProcedure);

            }
        }
        
    }
}
