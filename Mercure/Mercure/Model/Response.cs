using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercure.Model
{
    class Response
    {
        private bool State;
        private string Message;

        public bool State1
        {
            get
            {
                return State;
            }

            set
            {
                State = value;
            }
        }

        public string Message1
        {
            get
            {
                return Message;
            }

            set
            {
                Message = value;
            }
        }
    }
}
