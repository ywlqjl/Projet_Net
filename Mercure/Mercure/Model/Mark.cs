using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Mark
    {
        private int RefMarque;
        private string Nom;

        public int RefMarque1
        {
            get
            {
                return RefMarque;
            }

            set
            {
                RefMarque = value;
            }
        }

        public string Nom1
        {
            get
            {
                return Nom;
            }

            set
            {
                Nom = value;
            }
        }
        public override bool Equals(object obj)
        {
            Mark Mark = obj as Mark;
            return this.Nom.Equals(Mark.Nom);
        }

        public override int GetHashCode()
        {
            return this.Nom.GetHashCode();
        }
    }
}
