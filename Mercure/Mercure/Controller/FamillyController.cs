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

        public Response InsertFamillys(List<Familly> L_Familly)
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

        /// <summary>
        /// Delete one familly
        /// </summary>
        /// <param name="RefFamilly">Familly Reference</param>
        /// <returns>Response Object</returns>
        public Response DeleteFamilly(int RefFamilly)
        {
            Response Response = new Response();
            try
            {
                int Count = this.FamillyDAO.DeleteFamilly(RefFamilly);
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
        /// Update Familly
        /// </summary>
        /// <param name="RefFamilly">Familly Reference</param>
        /// <param name="Name">Familly Name</param>
        /// <returns>Response Object</returns>
        public Response UpdateFamilly(int RefFamilly, string Name)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                Familly Familly = this.FamillyDAO.MakeFamilly(RefFamilly, Name);
                Count = this.FamillyDAO.UpdateFamilly(Familly);

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
        /// Insert one familly
        /// </summary>
        /// <param name="RefFamilly">Familly Reference</param>
        /// <param name="Name">Familly Name</param>
        /// <returns>Response Object</returns>
        public Response InsertFamilly(int RefFamilly, string Name)
        {
            Response Response = new Response();
            try
            {
                Familly Familly = this.FamillyDAO.MakeFamilly(RefFamilly, Name);
                int Count = 0;  
                Count = FamillyDAO.InsertFamilly(Familly);
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
        /// Get Familly by refernece
        /// </summary>
        /// <param name="RefFamilly">Familly reference</param>
        /// <returns>Object Familly</returns>
        public Familly GetFamillyByRef(int RefFamilly)
        {
            return this.FamillyDAO.SelectFamillyByRef(RefFamilly);
        }

        /// <summary>
        /// Get all familly
        /// </summary>
        /// <returns>List of familly</returns>
        public List<Familly> GetAllFamilly()
        {
            return this.FamillyDAO.SelectAllFamilly();
        }

        /// <summary>
        /// get max id
        /// </summary>
        /// <returns>max id</returns>
        public int GetMaxFamillyId()
        {
            return this.FamillyDAO.GetMaxFamillyId();

        }
    }
}
