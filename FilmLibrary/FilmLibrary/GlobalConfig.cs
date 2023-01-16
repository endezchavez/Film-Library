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

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
