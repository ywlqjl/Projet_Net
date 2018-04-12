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
    class ArticleDAO
    {
        SQLiteConnection Connection;
        public ArticleDAO() {
            this.Connection = ConnectionDB.GetConnection();
        }

        public void InsertArticles(List<Article> L_Article) {
            Connection.Open();
            try {
                SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
                using (SQLiteTransaction Tran = Connection.BeginTransaction())
                {
                    foreach (Article Article in L_Article)
                    {
                        InsertCommand.CommandText = "INSERT INTO Articles VALUES(@Ref,@Des,@RefSubF,@RefM,@Price,@Quantity)";
                        InsertCommand.Parameters.AddRange(new[] {
                        new SQLiteParameter("@Ref",Article.RefArticle1),
                        new SQLiteParameter("@Des",Article.Description1),
                        new SQLiteParameter("@RefSubF",Article.RefSubFamilly1.RefSousFamille1),
                        new SQLiteParameter("@RefM",Article.RefMark1.RefMarque1),
                        new SQLiteParameter("@Price",Article.PriceHT1),
                        new SQLiteParameter("@Quantity",1),
                    });
                        Console.WriteLine(InsertCommand.CommandText);
                        InsertCommand.ExecuteNonQuery();
                    }
                    Tran.Commit();
                }
            }
            catch(Exception Exc){
                Console.WriteLine("Can't add a same list twice");
           }
            
            Connection.Close();
        }
    }
}
