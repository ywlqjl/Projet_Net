using Mercure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace Mercure
{
    class ReadFile
    {
        static XmlDocument xf;
        public static void LoadFile(string filename) {

            xf= new XmlDocument();
            xf.Load(filename);
            

        }


        static public List<OriArticle> GetInfoArticleList()
        {
            
            XmlNodeList ArticleNodes = xf.SelectNodes("//article");
            if (ArticleNodes.Count == 0)
            {
                throw new System.FormatException("File format incorrect!");
            }
            List<OriArticle> ArticleList = new List<OriArticle>();
            foreach (XmlNode article in ArticleNodes)
            {
                if (article != null)
                {
                    string Description = (article.SelectSingleNode("description")).InnerText;
                    string RefArticle = (article.SelectSingleNode("refArticle ")).InnerText;
                    string Marque = article.SelectSingleNode("marque").InnerText;
                    string Famille = article.SelectSingleNode("famille").InnerText;
                    string SousFamille = article.SelectSingleNode("sousFamille").InnerText;
                    string PrixHT = article.SelectSingleNode("prixHT").InnerText;

                    OriArticle ArticleNode = new OriArticle(Description, RefArticle, Marque, Famille, SousFamille, PrixHT);

                   // Console.WriteLine("Description:" + ArticleNode.Description1);
                    ArticleList.Add(ArticleNode);
                    //Console.WriteLine("Description:" + Description + "\nRefArticle:" + RefArticle + "\nMarque:" + Marque);
                }
                else
                {
                    Console.WriteLine("the node  is not existed");
                    //Console.Read();  
                }

            }
            return ArticleList;

        }
            



    }
}
