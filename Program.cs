using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PassWordAuthentication passwordService = new PassWordAuthentication();
            //FingerPrintAuthentication fingerPrintService = new FingerPrintAuthentication();
            //FaceRecognitionAuthentication faceRecognitionService = new FaceRecognitionAuthentication();

            //AuthenticationService.AuthenticateUser(passwordService);
            //AuthenticationService.AuthenticateUser(fingerPrintService);
            //AuthenticationService.AuthenticateUser(faceRecognitionService);

            PassWordAuthentication Pa = new PassWordAuthentication();
            AuthenticationService passwordService = new AuthenticationService(new PassWordAuthentication());
            AuthenticationService fingerPrintServices = new AuthenticationService(new FingerPrintAuthentication());
            AuthenticationService faceRecognitionServices = new AuthenticationService(new FaceRecognitionAuthentication());

            passwordService.AuthenticateUser();
            fingerPrintServices.AuthenticateUser();
            faceRecognitionServices.AuthenticateUser();


        }
            
    }
}
