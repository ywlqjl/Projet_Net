using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercure.Dao;
using Mercure.Model;
namespace Mercure.Controller
{
    /// <summary>
    /// Subfamily controller to find, add, delete, update from the subfamily database
    /// </summary>
    class SubFamillyController: CommonDelegate
    {
        SubFamillyDAO SubFamillyDAO = new SubFamillyDAO();

        /// <summary>
        /// Add into the subfamily database
        /// </summary>
        /// <param name="L_SubFamilly"></param>
        /// <returns></returns>
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
            }
            catch (Exception E)
            {
                Response.State1 = false;
                Response.Message1 = E.Message;
            }
            return Response;
        }

        /// <summary>
        /// Delete all the subfamily items from the database
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Delete one Subfamilly
        /// </summary>
        /// <param name="RefSubFamilly">SubFamilly Reference</param>
        /// <returns>Object Response</returns>
        public Response DeleteSubFamilly(int RefSubFamilly)
        {
            Response Response = new Response();
            try
            {
                int Count = this.SubFamillyDAO.DeleteSubFamilly(RefSubFamilly);
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
        /// Update SubFamilly
        /// </summary>
        /// <param name="RefSubFamilly">SubFamilly reference</param>
        /// <param name="RefFamilly">Familly reference</param>
        /// <param name="Name">Subfamilly name</param>
        /// <returns>Response object</returns>
        public Response UpdateSubFamilly(int RefSubFamilly, int RefFamilly,string Name)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                SubFamilly SubFamilly = this.SubFamillyDAO.MakeSubFamilly(RefSubFamilly, RefFamilly, Name);
                Count = this.SubFamillyDAO.UpdateSubFamilly(SubFamilly);

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
        /// Insert One subfamilly
        /// </summary>
        /// <param name="RefSubFamilly">SubFamilly reference</param>
        /// <param name="RefFamilly">Familly reference</param>
        /// <param name="Name">Subfamilly name</param>
        /// <returns>Response object</returns>
        public Response InsertSubFamilly(int RefSub, int RefFamilly, string Name)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                SubFamilly SubFamilly = this.SubFamillyDAO.MakeSubFamilly(RefSub, RefFamilly, Name);
                Count = SubFamillyDAO.InsertSubFamilly(SubFamilly);
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
        /// Get Subfamilly by reference
        /// </summary>
        /// <param name="RefSubFamilly">SubFmilly Reference</param>
        /// <returns>SubFamilly Object</returns>
        public SubFamilly GetSubFamillyByRef(int RefSubFamilly)
        {
            return this.SubFamillyDAO.SelectSubFamillyByRef(RefSubFamilly);
        }

        /// <summary>
        /// Get all subfamilly
        /// </summary>
        /// <returns>List of subfamilly</returns>
        public List<SubFamilly> GetAllSubFamilly()
        {
            return this.SubFamillyDAO.SelectAllSubFamilly();
        }

        /// <summary>
        /// get max sub familly id
        /// </summary>
        /// <returns></returns>
        public int GetMaxSubFamillyId()
        {
            return this.SubFamillyDAO.GetMaxSubFamillyId();
        }

    }
}
