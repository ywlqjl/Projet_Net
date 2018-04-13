using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;

namespace Mercure.Controller
{
    class ArticleController : CommonDelegate
    {
        ArticleDAO ArticleDAO = new ArticleDAO();
        public Response InsertArticles(List<Article> L_Article) {
            Response Response = new Response();
            try
            {
                int Count = 0;
                foreach (Article Article in L_Article)
                {
                    Count = ArticleDAO.InsertArticle(Article);

                    // event happen
                    this.OnOperated(Count, "Inserting Article "+Article.RefArticle1);
                }
                Response.State1 = true;
                Response.Message1 = Count.ToString();
                return Response;
            }
            catch (Exception E) {
                Response.State1 = false;
                Response.Message1 = E.Message;
                return Response;
            }
        }

        public Response DeleteAllArticle()
        {
            Response Response = new Response();
            try
            {
                int Count = this.ArticleDAO.DeleteAllArticles();

                // event happen
                this.OnOperated(Count, "Deleting Article");

                Response.State1 = true;
                Response.Message1 = Count.ToString();
                return Response;
            }
            catch (Exception E)
            {
                Response.State1 = false;
                Response.Message1 = E.Message;
                return Response;
            }
        }

        public List<Article> GetAllArticle()
        {
            return this.ArticleDAO.SelectAllArticle();
        }
    }
}
