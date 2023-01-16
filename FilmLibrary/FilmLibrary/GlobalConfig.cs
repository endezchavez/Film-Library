using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmLibrary.DataAccess;
using System.Configuration;

namespace FilmLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Intializes the connection tpye (Text File or Databse)
        /// </summary>
        /// <param name="connectionType">The type of connection to be used</param>
        public static void InitializeConnections(DatabaseType connectionType)
        {
            if (connectionType == DatabaseType.SQL)
            {
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (connectionType == DatabaseType.TEXT_FILE)
            {
                TextConnector text = new TextConnector();
                Connection = text; 
            }
        }

        /// <summary>
        /// The connection string required for conencting to the database
        /// </summary>
        /// <param name="name">The name of the database we are connecting to</param>
        /// <returns>A string that contains the data required for connecting to the database</returns>
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
