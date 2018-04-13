using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;
namespace Mercure.Controller
{
    class MarkController:CommonDelegate
    {
        MarkDAO MarkDAO = new MarkDAO();
        public Response InsertMarks(List<Mark> L_Mark) {
            Response Response = new Response();
            try
            {
                int Count = 0;
                foreach (Mark Mark in L_Mark)
                {
                    Count = MarkDAO.InsertMark(Mark);

                    // event happen
                    this.OnOperated(Count, "Inserting Mark " + Mark.Nom1);
                }
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

        public Response DeleteAllMark()
        {
            Response Response = new Response();
            try
            {
                int Count = this.MarkDAO.DeleteAllMark();
                // event happen
                this.OnOperated(Count, "Deleting Mark");

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
    }
}
