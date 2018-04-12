using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Article
    {
        private string RefArticle;      
        private string Description;
        private float PriceHT;
        private int Quantity;
        private SubFamilly RefSubFamilly;
        private Mark RefMark;

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

        public float PriceHT1
        {
            get
            {
                return PriceHT;
            }

            set
            {
                PriceHT = value;
            }
        }

        public int Quantity1
        {
            get
            {
                return Quantity;
            }

            set
            {
                Quantity = value;
            }
        }

        internal SubFamilly RefSubFamilly1
        {
            get
            {
                return RefSubFamilly;
            }

            set
            {
                RefSubFamilly = value;
            }
        }

        internal Mark RefMark1
        {
            get
            {
                return RefMark;
            }

            set
            {
                RefMark = value;
            }
        }
    }
}
