using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class OriArticle
    {
        private string Description;
        private string RefArticle;
        private string Marque;
        private string Famille;
        private string SousFamille;
        private string PrixHT;

        public string Description1
        {
            get
            {
                return Description;
            }

            set
            {
                Description = value;
            }
        }

        public string RefArticle1
        {
            get
            {
                return RefArticle;
            }

            set
            {
                RefArticle = value;
            }
        }

        public string Marque1
        {
            get
            {
                return Marque;
            }

            set
            {
                Marque = value;
            }
        }

        public string Famille1
        {
            get
            {
                return Famille;
            }

            set
            {
                Famille = value;
            }
        }

        public string SousFamille1
        {
            get
            {
                return SousFamille;
            }

            set
            {
                SousFamille = value;
            }
        }

        public string PrixHT1
        {
            get
            {
                return PrixHT;
            }

            set
            {
                PrixHT = value;
            }
        }

        public OriArticle(string description, string refArticle, string marque, string famille, string sousFamille, string prixHT)
        {
            Description1 = description;
            RefArticle1 = refArticle;
            Marque1 = marque;
            Famille1 = famille;
            SousFamille1 = sousFamille;
            PrixHT1 = prixHT;
        }
    }
}
