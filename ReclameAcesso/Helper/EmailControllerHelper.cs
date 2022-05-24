using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReclameAcesso.Helper
{
    class EmailControllerHelper : Exception
    {
        public EmailControllerHelper(string message) : base(message)
        {

        }

        public EmailControllerHelper(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
