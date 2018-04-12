using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Familly
    {
        private int RefFamille;
        private string Nom;

        public int RefFamille1
        {
            get
            {
                return RefFamille;
            }

            set
            {
                RefFamille = value;
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
            Familly Familly = obj as Familly;
            return this.Nom.Equals(Familly.Nom);
        }

        public override int GetHashCode()
        {
            return this.Nom.GetHashCode();
        }
    }
}
