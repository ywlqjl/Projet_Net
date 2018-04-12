using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Model;
using System.Data.SQLite;
using Mercure.Controller;
namespace Mercure.Dao
{

    class MarkDAO
    {
        SQLiteConnection Connection;
        public MarkDAO() {
            this.Connection = ConnectionDB.GetConnection();
        }

        public void InsertMarks(List<Mark> L_Mark) {
            Connection.Open();
            try
            {
                SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
                using (SQLiteTransaction Tran = Connection.BeginTransaction())
                {
                    foreach (Mark Mark in L_Mark)
                    {
                        InsertCommand.CommandText = "INSERT INTO Marques VALUES(@Ref,@Nom)";
                        InsertCommand.Parameters.AddRange(new[] {
                       new SQLiteParameter("@Ref",Mark.RefMarque1),
                       new SQLiteParameter("@Nom",Mark.Nom1)
                    });
                        InsertCommand.ExecuteNonQuery();
                    }
                    Tran.Commit();
                }
            }
            catch (Exception Exc) {
                Console.WriteLine("Erro");
            }
            
            Connection.Close();
        }
    }
}
