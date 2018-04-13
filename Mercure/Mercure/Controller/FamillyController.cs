using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;
namespace Mercure.Controller
{
    class FamillyController:CommonDelegate
    {
        FamillyDAO FamillyDAO = new FamillyDAO();

        public Response InsertSubFamillys(List<Familly> L_Familly)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                foreach (Familly Familly in L_Familly)
                {
                    Count = FamillyDAO.InsertFamilly(Familly);

                    // event happen
                    this.OnOperated(Count, "Inserting Familly " + Familly.Nom1);
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

        public Response DeleteAllFamilly()
        {
            Response Response = new Response();
            try
            {
                int Count = this.FamillyDAO.DeleteAllFamilly();

                // event happen
                this.OnOperated(Count, "Deleting Familly");
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
