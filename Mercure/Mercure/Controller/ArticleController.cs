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

        /// <summary>
        /// Delete all article
        /// </summary>
        /// <returns>Response Object</returns>
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

        /// <summary>
        /// Update an article
        /// </summary>
        /// <param name="Ref">Reference Article</param>
        /// <param name="Des">Description</param>
        /// <param name="RefSubF">Reference Sub Familly</param>
        /// <param name="RefMark">Reference Brand</param>
        /// <param name="Price">Price</param>
        /// <param name="Quantity">Quantity</param>
        /// <returns>Response Object</returns>
        public Response UpdateArticle(string Ref, string Des, int RefSubF, int RefMark, float Price, int Quantity)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                Article Article = ArticleDAO.MakeArticle(Ref, Des, RefSubF, RefMark, Price, Quantity);
                Count = ArticleDAO.UpdateArticle(Article);

                Response.State1 = true;
                Response.Message1 = Count.ToString();
            }
            catch (Exception E)
            {
                Response.State1 = false;
                Response.Message1 = E.Message;
            }
            return Response;
        }

        /// <summary>
        /// Delete article by reference
        /// </summary>
        /// <param name="RefArticle">Ref Article</param>
        /// <returns>Response Object</returns>
        public Response DeleteArticle(string RefArticle)
        {
            Response Response = new Response();
            try
            {
                int Count = this.ArticleDAO.DeleteArticle(RefArticle);
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

        /// <summary>
        /// Insert an Article
        /// </summary>
        /// <param name="Ref">Article Reference</param>
        /// <param name="Des">Description</param>
        /// <param name="RefSubF">Sub Familly Reference</param>
        /// <param name="RefMark">Brand Reference</param>
        /// <param name="Price">Price</param>
        /// <param name="Quantity">Quantity</param>
        /// <returns>Response Object</returns>
        public Response InsertArticle(string Ref, string Des, int RefSubF, int RefMark, float Price, int Quantity)
        {
            Response Response = new Response();
            try
            {
                Article Article = this.ArticleDAO.MakeArticle(Ref, Des, RefSubF, RefMark, Price, Quantity);
                int Count = 0;
                Count = ArticleDAO.InsertArticle(Article);
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

        /// <summary>
        /// Get Article by reference
        /// </summary>
        /// <param name="RefArticle">Article Reference</param>
        /// <returns>Object Article</returns>
        public Article GetArticleByRef(string RefArticle)
        {
            return this.ArticleDAO.SelectArticleByRef(RefArticle);
        }
    }
}
