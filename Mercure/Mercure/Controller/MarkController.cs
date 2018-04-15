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

        /// <summary>
        /// Delete one Mark
        /// </summary>
        /// <param name="RefMark">Mark Reference</param>
        /// <returns>Response Object</returns>
        public Response DeleteMark(int RefMark)
        {
            Response Response = new Response();
            try
            {
                int Count = this.MarkDAO.DeleteMark(RefMark);
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
        /// Update Mark
        /// </summary>
        /// <param name="RefMark">Mark Refernece</param>
        /// <param name="Name">Mark Name</param>
        /// <returns>Response Object</returns>
        public Response UpdateMark(int RefMark, string Name)
        {
            Response Response = new Response();
            try
            {
                int Count = 0;
                Mark Mark = this.MarkDAO.MakeMark(RefMark, Name);
                Count = this.MarkDAO.UpdateMark(Mark);

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
        /// Insert one Mark
        /// </summary>
        /// <param name="RefMark">Mark Reference</param>
        /// <param name="Name">Mark Name</param>
        /// <returns>Response Object</returns>
        public Response InsertMark(int RefMark, string Name)
        {
            Response Response = new Response();
            try
            {
                Mark Mark = this.MarkDAO.MakeMark(RefMark, Name);
                int Count = 0;
                Count = MarkDAO.InsertMark(Mark);
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
        /// Get Mark by reference
        /// </summary>
        /// <param name="RefMark">Mark Reference</param>
        /// <returns>Object Mark</returns>
        public Mark GetMarkByRef(int RefMark)
        {
            return this.MarkDAO.SelectMarkByRef(RefMark);
        }

    }
}
