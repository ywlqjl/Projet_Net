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
        public void InsertArticles(List<Article> L_Article) {
            ArticleDAO.InsertArticles(L_Article);
        }
    }
}
