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

        public void LoadFile(string filename) {

            XmlDocument xf = new XmlDocument();
            xf.Load(filename);

            XmlNode root = xf.SelectSingleNode("//article");//if the node go with some attributs, it doesn't work          
            if (root != null)
            {
                string Description = (root.SelectSingleNode("description")).InnerText;
                string RefArticle = (root.SelectSingleNode("refArticle ")).InnerText;
                string Marque = root.SelectSingleNode("marque").InnerText;
                string Famille = root.SelectSingleNode("famille").InnerText;
                string SousFamille = root.SelectSingleNode("sousFamille").InnerText;
                string PrixHT = root.SelectSingleNode("prixHT").InnerText;

                Console.WriteLine("Description:" + Description + "\nRefArticle:" + RefArticle + "\nMarque:" + Marque);
            }
            else
            {
                Console.WriteLine("the node  is not existed");
                //Console.Read();  
            }

        }


     
       

    }
}
