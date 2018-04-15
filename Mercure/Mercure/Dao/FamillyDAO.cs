using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Mercure.Controller;
using Mercure.Model;
namespace Mercure.Dao
{
    class FamillyDAO
    {
        SQLiteConnection Connection;
        public FamillyDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
        }

        public Familly SelectFamillyByRef(int Ref)
        {
            Familly Familly = null;
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM Familles WHERE RefFamille = @Ref";
                SelectCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Ref)
                });
               
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.HasRows)
                {
                    reader.Read();
                    Familly = this.MakeFamilly( int.Parse(reader["RefFamille"].ToString()), reader["Nom"].ToString());
                }


                return Familly;

            }
        }

        public Familly MakeFamilly(int RefFamilly, string Name)
        {
            Familly Familly = new Familly();
            Familly.RefFamille1 = RefFamilly;
            Familly.Nom1 = Name;
            

            return Familly;
        }

        public int InsertFamilly(Familly Familly)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                if (this.SelectFamillyByRef(Familly.RefFamille1) == null)
                {
                    InsertCommand.CommandText = "INSERT INTO Familles VALUES(@RefF,@Nom)";
                    InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@RefF",Familly.RefFamille1),
                    new SQLiteParameter("@Nom",Familly.Nom1)
                 });
                    Count = InsertCommand.ExecuteNonQuery();
                    Tran.Commit();
                }

            }
            return Count;
        }

        public int InsertFamillys(List<Familly> L_Familly)
        {
            int Count = 0;
            foreach (Familly Familly in L_Familly)
            {
                Count += this.InsertFamilly(Familly);
            }
            return Count;
        }

        public int DeleteAllFamilly()
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM Familles";


                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }

        /// <summary>
        /// Delete one familly
        /// </summary>
        /// <param name="RefFamilly">Familly Reference</param>
        /// <returns>Number of row</returns>
        public int DeleteFamilly(int RefFamilly)
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM Familles WHERE RefFamille = @Ref";
                DeleteCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",RefFamilly)
                });
                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return 0;
        }

        /// <summary>
        /// Update familly
        /// </summary>
        /// <param name="Familly">Object Familly</param>
        /// <returns>Number of row</returns>
        public int UpdateFamilly(Familly Familly)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "UPDATE Familles SET Nom = @Nom WHERE RefFamille = @Ref";
                InsertCommand.Parameters.AddRange(new[] {     
                    new SQLiteParameter("@Nom",Familly.Nom1),
                    new SQLiteParameter("@Ref",Familly.RefFamille1),
                });
                Count = InsertCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }

        /// <summary>
        /// Select all familly
        /// </summary>
        /// <returns>List of familly</returns>
        public List<Familly> SelectAllFamilly()
        {
            List<Familly> L_Familly = new List<Familly>();
           
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM Familles";
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                while (reader.Read())
                {
                    Familly Familly = this.MakeFamilly(int.Parse(reader["RefFamille"].ToString()), reader["Nom"].ToString());
                    L_Familly.Add(Familly);
                }
            }
            return L_Familly;
        }
    }
}

