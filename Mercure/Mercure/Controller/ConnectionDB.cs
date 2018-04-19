using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

/// <summary>
/// Class to get database connection. Singleton
/// </summary>
namespace Mercure.Controller
{
    class ConnectionDB
    {
        
        private static SQLiteConnection Connection = null;
        private ConnectionDB() { }

        /// <summary>
        /// get database connection
        /// </summary>
        /// <returns>Connection object</returns>
        public static SQLiteConnection GetConnection() {
            string Path = "Data Source=" + Environment.CurrentDirectory + "/Mercure.SQLite";
            
            if (Connection == null)
            {
                Connection = new SQLiteConnection(Path);
                return Connection;
            }
            else {
                return Connection;
            }
            
        }
    }
}
