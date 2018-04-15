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

        public Mark MakeMark(int Ref, string Name) {
            Mark Mark = new Mark();
            Mark.RefMarque1 = Ref;
            Mark.Nom1 = Name;
            return Mark;
        }

        public Mark SelectMarkByRef(int Ref) {
            Mark Mark = null;
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM Marques WHERE RefMarque = @Ref";
                SelectCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Ref)
                });
               
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.HasRows)
                {
                    reader.Read();
                    Mark = this.MakeMark(int.Parse(reader["RefMarque"].ToString()),reader["Nom"].ToString());
                }


                return Mark;

            }
        }

        public int InsertMark(Mark Mark) {
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            int Count = 0;
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                if (this.SelectMarkByRef(Mark.RefMarque1) == null) {
                    InsertCommand.CommandText = "INSERT INTO Marques VALUES(@Ref,@Nom)";
                    InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Mark.RefMarque1),
                    new SQLiteParameter("@Nom",Mark.Nom1)
                 });
                    Count = InsertCommand.ExecuteNonQuery();
                    Tran.Commit();
                }
                
            }
            return Count;
        }

        public int InsertMarks(List<Mark> L_Mark)
        {
            int Count = 0;
            foreach (Mark Mark in L_Mark)
            {
                Count += this.InsertMark(Mark);
            }
            return Count;
        }

        public int DeleteAllMark()
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM Marques";


                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }

        /// <summary>
        /// Delete Mark
        /// </summary>
        /// <param name="RefMark">Mark Reference</param>
        /// <returns>Number of row</returns>
        public int DeleteMark(int RefMark)
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM Marques WHERE RefMarque = @Ref";
                DeleteCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",RefMark),
                    
                 });
                Count = DeleteCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }

        /// <summary>
        /// Update Mark
        /// </summary>
        /// <param name="Mark">Object Mark</param>
        /// <returns>Number of row</returns>
        public int UpdateMark(Mark Mark)
        {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                InsertCommand.CommandText = "UPDATE Marques SET Nom = @Nom WHERE RefMarque = @Ref";
                InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Nom",Mark.Nom1),
                    new SQLiteParameter("@Ref",Mark.RefMarque1),
                });
                Count = InsertCommand.ExecuteNonQuery();
                Tran.Commit();
            }
            return Count;
        }
    }
}
