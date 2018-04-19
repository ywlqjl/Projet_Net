using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Delegate of database operation for importing file
/// </summary>
namespace Mercure.Controller
{
    class CommonDelegate
    {
        public delegate void OperationHandler(int Count, string Msg);
        public event OperationHandler Operated;

        protected virtual void OnOperated(int Count, string Msg)
        {
            if (Operated != null)
            {
                Operated(Count, Msg);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
