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
    class SubFamillyDAO
    {
        SQLiteConnection Connection;
        public SubFamillyDAO()
        {
            this.Connection = ConnectionDB.GetConnection();
        }

        public SubFamilly SelectSubFamillyByRef(int Ref)
        {
            SubFamilly SubFamilly = null;
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM SousFamilles WHERE RefSousFamille = @Ref";
                SelectCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Ref)
                });
               
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.HasRows)
                {
                    reader.Read();
                    SubFamilly = this.MakeSubFamilly(int.Parse(reader["RefSousFamille"].ToString()),int.Parse(reader["RefFamille"].ToString()) ,reader["Nom"].ToString());
                }


                return SubFamilly;

            }
        }

        private SubFamilly MakeSubFamilly(int RefSub,int RefFamilly, string Name)
        {
            SubFamilly SubFamilly = new SubFamilly();
            SubFamilly.RefSousFamille1 = RefSub;
            SubFamilly.Nom1 = Name;

            //insert familly
            FamillyDAO FamillyDAO = new FamillyDAO();

            SubFamilly.RefFamille1 = FamillyDAO.SelectFamillyByRef(RefFamilly);

            return SubFamilly;
        }

        public int InsertSubFamilly(SubFamilly SubFamilly)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                if (this.SelectSubFamillyByRef(SubFamilly.RefSousFamille1) == null)
                {
                    InsertCommand.CommandText = "INSERT INTO SousFamilles VALUES(@RefSUB,@RefF,@Nom)";
                    InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@RefSUB",SubFamilly.RefSousFamille1),
                    new SQLiteParameter("@RefF",SubFamilly.RefFamille1.RefFamille1),
                    new SQLiteParameter("@Nom",SubFamilly.Nom1)
                 });
                    Count = InsertCommand.ExecuteNonQuery();
                    Tran.Commit();
                }

            }
            return Count;
        }

        public int InsertSubFamillys(List<SubFamilly> L_SubFamilly)
        {
            int Count = 0;
            foreach (SubFamilly SubFamilly in L_SubFamilly)
            {
                Count += this.InsertSubFamilly(SubFamilly);
            }
            return Count;
        }

        public int DeleteAllSubFamilly()
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM SousFamilles";
                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }
    }
}
