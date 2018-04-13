using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Mercure.Controller
{
    class ConnectionDB
    {
        
        private static SQLiteConnection Connection = null;
        private ConnectionDB() { }
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
