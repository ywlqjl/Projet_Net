using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class SubFamilly
    {
        private int RefSousFamille;
        private Familly RefFamille;
        private string Nom;

        public int RefSousFamille1
        {
            get
            {
                return RefSousFamille;
            }

            set
            {
                RefSousFamille = value;
            }
        }

        public Familly RefFamille1
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
            SubFamilly SubFamilly = obj as SubFamilly;
            return this.Nom.Equals(SubFamilly.Nom);
        }

        public override int GetHashCode()
        {
            return this.Nom.GetHashCode();
        }
    }
}
