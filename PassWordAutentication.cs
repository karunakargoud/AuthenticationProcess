using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationProcess
{
    internal class PassWordAuthentication : IAuthenticator
    {
        public bool Authenticate()
        {
            Console.WriteLine("Authentication using Password...");
            return true;
        }
    }
}
