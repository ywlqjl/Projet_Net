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

        private Article MakeArticle(string Ref, string Des, int RefSubF, int RefMark, float Price, int Quantity) {
            Article Article = new Article();
            Article.RefArticle1 = Ref;
            Article.Description1 = Des;
            Article.PriceHT1 = Price;
            Article.Quantity1 = Quantity;

            // insert mark
            MarkDAO MarkDAO = new MarkDAO();
            Article.RefMark1 = MarkDAO.SelectMarkByRef(RefMark);

            //insert subfamilly
            SubFamillyDAO SubFamillyDAO = new SubFamillyDAO();
            Article.RefSubFamilly1 = SubFamillyDAO.SelectSubFamillyByRef(RefSubF);


            return Article;
        }

        public int InsertArticles(List<Article> L_Article) {
            int Count = 0;
            foreach (Article Article in L_Article)
            {
               Count += this.InsertArticle(Article);
            }
            return Count;
        }

        public int InsertArticle(Article Article) {
            int Count = 0;
            SQLiteCommand InsertCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                Article Art = this.SelectArticleByRef(Article.RefArticle1);
                // update
                if (Art != null)
                {
                    InsertCommand.CommandText = "UPDATE Articles SET Quantite = @Quantity WHERE RefArticle = @Ref";
                    InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Art.RefArticle1),
                    new SQLiteParameter("@Quantity",Art.Quantity1+1),
                });
                }
                else {
                    InsertCommand.CommandText = "INSERT INTO Articles VALUES(@Ref,@Des,@RefSubF,@RefM,@Price,@Quantity)";
                    InsertCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Article.RefArticle1),
                    new SQLiteParameter("@Des",Article.Description1),
                    new SQLiteParameter("@RefSubF",Article.RefSubFamilly1.RefSousFamille1),
                    new SQLiteParameter("@RefM",Article.RefMark1.RefMarque1),
                    new SQLiteParameter("@Price",Article.PriceHT1),
                    new SQLiteParameter("@Quantity",1),
                });

                }


                Count = InsertCommand.ExecuteNonQuery();
               
                Tran.Commit();
                
            }
            return Count;


        }

        public Article SelectArticleByRef(string Ref)
        {

            Article Article = null;
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM Articles WHERE RefArticle = @Ref";
                SelectCommand.Parameters.AddRange(new[] {
                    new SQLiteParameter("@Ref",Ref)
                });
               
                SQLiteDataReader reader =  SelectCommand.ExecuteReader();
                Tran.Commit();
                if (reader.HasRows)
                {
                    reader.Read();
                    Article = this.MakeArticle(reader["RefArticle"].ToString(), reader["Description"].ToString(),
                        int.Parse(reader["RefSousFamille"].ToString()), int.Parse(reader["RefMarque"].ToString()),float.Parse(reader["PrixHT"].ToString()),
                        int.Parse(reader["Quantite"].ToString()));                 
                } 
            }
            return Article;
        }

        public int DeleteAllArticles()
        {
            int Count = 0;
            SQLiteCommand DeleteCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                DeleteCommand.CommandText = "Delete FROM Articles";
               

                Count =  DeleteCommand.ExecuteNonQuery();
                Tran.Commit(); 
            }

            return Count;
        }

        public List<Article> SelectAllArticle()
        {
            List<Article> L_Article = new List<Article>();
            SQLiteCommand SelectCommand = new SQLiteCommand(Connection);
            using (SQLiteTransaction Tran = Connection.BeginTransaction())
            {
                SelectCommand.CommandText = "SELECT * FROM Articles";
                SQLiteDataReader reader = SelectCommand.ExecuteReader();
                Tran.Commit();
                while (reader.Read())
                {
                    Article Article = this.MakeArticle(reader["RefArticle"].ToString(), reader["Description"].ToString(),
                        int.Parse(reader["RefSousFamille"].ToString()), int.Parse(reader["RefMarque"].ToString()), float.Parse(reader["PrixHT"].ToString()),
                        int.Parse(reader["Quantite"].ToString()));
                    L_Article.Add(Article);
                }
            }
            return L_Article;
        }
    }
}
