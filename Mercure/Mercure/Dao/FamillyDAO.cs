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

        private Familly MakeFamilly(int RefFamilly, string Name)
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
    }
}

