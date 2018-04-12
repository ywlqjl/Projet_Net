using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;
namespace Mercure.Controller
{
    class MarkController
    {
        MarkDAO MarkDAO = new MarkDAO();
        public void InsertMarks(List<Mark> L_Mark) {
            this.MarkDAO.InsertMarks(L_Mark);
        }
    }
}
