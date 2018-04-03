﻿using Mercure.Model;
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
        string filename;
        string filepath;
        XmlDocument xf;
        public void LoadFile(string filename) {

            xf= new XmlDocument();
            xf.Load(filename);

            //XmlNode root = xf.SelectSingleNode("//article");//if the node go with some attributs, it doesn't work          
            //if (root != null)
            //{
            //    string Description = (root.SelectSingleNode("description")).InnerText;
            //    string RefArticle = (root.SelectSingleNode("refArticle ")).InnerText;
            //    string Marque = root.SelectSingleNode("marque").InnerText;
            //    string Famille = root.SelectSingleNode("famille").InnerText;
            //    string SousFamille = root.SelectSingleNode("sousFamille").InnerText;
            //    string PrixHT = root.SelectSingleNode("prixHT").InnerText;

            //    Console.WriteLine("Description:" + Description + "\nRefArticle:" + RefArticle + "\nMarque:" + Marque);
            //}
            //else
            //{
            //    Console.WriteLine("the node  is not existed");
            //    //Console.Read();  
            //}

        }


        public List<OriArticle> GetInfoArticleList()
        {


            XmlNodeList ArticleNodes = xf.SelectNodes("//article");

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

                    Console.WriteLine("Description:" + ArticleNode.Description1);
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
