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

        public SubFamilly MakeSubFamilly(int RefSub,int RefFamilly, string Name)
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

        /// <summary>
        /// Delete one Subfamilly
        /// </summary>
        /// <param name="RefSubFamilly">SubFamilly Reference</param>
        /// <returns>Number of row</returns>
        public int DeleteSubFamilly(int RefSubFamilly)
        {
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT Count(*) FROM Articles WHERE RefSousFamille = @Ref";
                SelectCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",RefSubFamilly)
                });
            
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.Read())
                {
                    if (int.Parse(reader[0].ToString()) != 0)
                        throw new Exception("Can't delete subfamily!");
                }
            }

            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM SousFamilles WHERE RefSousFamille = @Ref";
                DeleteCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",RefSubFamilly),
                 });
                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }


        /// <summary>
        /// Update SubFamilly
        /// </summary>
        /// <param name="SubFamilly">Object SubFamilly</param>
        /// <returns>Number of row</returns>
        public int UpdateSubFamilly(SubFamilly SubFamilly)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "UPDATE SousFamilles SET Nom = @Nom, RefFamille = @RefFamille WHERE RefSousFamille = @Ref";
                InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Nom",SubFamilly.Nom1),
                    new SQLiteParameter("@RefFamille",SubFamilly.RefFamille1.RefFamille1),
                    new SQLiteParameter("@Ref",SubFamilly.RefSousFamille1),
                });
                Count = InsertCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }

        /// <summary>
        /// Select all SubFamilly
        /// </summary>
        /// <returns>List of subfamilly</returns>
        public List<SubFamilly> SelectAllSubFamilly()
        {
            List<SubFamilly> L_SubFamilly = new List<SubFamilly>();
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM SousFamilles";

                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                while (reader.Read())
                {
                    SubFamilly SubFamilly = this.MakeSubFamilly(int.Parse(reader["RefSousFamille"].ToString()), int.Parse(reader["RefFamille"].ToString()), reader["Nom"].ToString());
                    L_SubFamilly.Add(SubFamilly);
                }
            }
            return L_SubFamilly;
        }

        /// <summary>
        /// get max sub familly id
        /// </summary>
        /// <returns></returns>
        public int GetMaxSubFamillyId()
        {
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT MAX(RefSousFamille) FROM SousFamilles";
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.Read())
                {
                    return int.Parse(reader[0].ToString());
                }
            }
            return 0;
        }
    }
}
