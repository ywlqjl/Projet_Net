using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;

namespace Mercure.Controller
{
    class ArticleController
    {
        ArticleDAO ArticleDAO = new ArticleDAO();
        public Response InsertArticles(List<Article> L_Article) {
            Response Response = new Response();
            try
            {
                int Count = 0;
                Count =  ArticleDAO.InsertArticles(L_Article);
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
