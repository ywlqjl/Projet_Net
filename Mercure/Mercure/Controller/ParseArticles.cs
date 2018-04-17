using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Model;
namespace Mercure.Controller
{
    class ParseArticles
    {
        private List<OriArticle> List_Ori_Ari;
        private List<Mark> L_Mark = new List<Mark>();
        private List<Familly> L_Familly = new List<Familly>();
        private List<SubFamilly> L_SubFamilly = new List<SubFamilly>();
        private List<Article> L_Article = new List<Article>();

        public ParseArticles(List<OriArticle> List_Ori_Ari) {
            this.List_Ori_Ari = List_Ori_Ari;
        }
        public List<Article> ParseArticle() {
            // data structures
           

            int Mark_Count = 1;
            int SubFam_Count = 1;
            int Fam_Count = 1;
            foreach (OriArticle OriArc in this.List_Ori_Ari) {
                
                // set articles
                Article Art = new Article();
                Art.RefArticle1 = OriArc.RefArticle1;
                Art.Description1 = OriArc.Description1;
                Art.PriceHT1 = float.Parse(OriArc.PrixHT1.Replace(',','.'));
                //try catch here

                // set mark
                Mark Mark = new Mark();
                Mark.RefMarque1 = Mark_Count;
                Mark.Nom1 = OriArc.Marque1;
                if (L_Mark.Contains(Mark)) {
                    int Id = L_Mark.IndexOf(Mark);
                    Mark = L_Mark.ElementAt(Id);
                }
                else {
                    Mark_Count++;
                    L_Mark.Add(Mark);
                }
                Art.RefMark1 = Mark;

                // set familly
                Familly Familly = new Familly();
                Familly.Nom1 = OriArc.Famille1;
                Familly.RefFamille1 = Fam_Count;

                if (L_Familly.Contains(Familly))
                {
                    int Id = L_Familly.IndexOf(Familly);
                    Familly = L_Familly.ElementAt(Id);
                }
                else {
                    Fam_Count++;
                    L_Familly.Add(Familly);
                }
              

                // set subfamilly
                SubFamilly SubFamilly = new SubFamilly();
                SubFamilly.Nom1 = OriArc.SousFamille1;
                SubFamilly.RefSousFamille1 = SubFam_Count;
                SubFamilly.RefFamille1 = Familly;
                if (L_SubFamilly.Contains(SubFamilly))
                {
                    int Id = L_SubFamilly.IndexOf(SubFamilly);
                    SubFamilly = L_SubFamilly.ElementAt(Id);
                }
                else {
                    SubFam_Count++;
                    L_SubFamilly.Add(SubFamilly);
                }

                Art.RefSubFamilly1 = SubFamilly;

                // add to list
                L_Article.Add(Art);
            }
            return L_Article;
        }

        internal List<Mark> L_Mark1
        {
            get
            {
                return L_Mark;
            }

            set
            {
                L_Mark = value;
            }
        }

        internal List<Familly> L_Familly1
        {
            get
            {
                return L_Familly;
            }

            set
            {
                L_Familly = value;
            }
        }

        internal List<SubFamilly> L_SubFamilly1
        {
            get
            {
                return L_SubFamilly;
            }

            set
            {
                L_SubFamilly = value;
            }
        }
    }
}
