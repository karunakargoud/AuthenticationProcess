using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationProcess
{
    internal class AuthenticationService
    {
        //public static void AuthenticateUser(IAuthenticator Db)
        //{
        //    Db.Authenticate();
        //}
        private IAuthenticator _authenticate;
        public AuthenticationService(IAuthenticator authenticate)
        {
            _authenticate = authenticate;
        }
        public void AuthenticateUser()
        {
            if (_authenticate.Authenticate())
            {
                Console.WriteLine("Authentication is successful...");
            }
            else
            {
                Console.WriteLine("Authentication is failure...");
            }


        }
    }
}
