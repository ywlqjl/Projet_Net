using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;
namespace Mercure.Controller
{
    class SubFamillyController: CommonDelegate
    {
        SubFamillyDAO SubFamillyDAO = new SubFamillyDAO();

        public Response InsertSubFamillys(List<SubFamilly> L_SubFamilly)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                foreach (SubFamilly SubFamilly in L_SubFamilly)
                {
                    Count = SubFamillyDAO.InsertSubFamilly(SubFamilly);

                    // event happen
                    this.OnOperated(Count, "Inserting SubFamilly " + SubFamilly.Nom1);
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

        public Response DeleteAllSubFamilly()
        {
            Response Response = new Response();
            try
            {
                int Count = this.SubFamillyDAO.DeleteAllSubFamilly();

                // event happen
                this.OnOperated(Count, "Deleting SubFamilly");
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
