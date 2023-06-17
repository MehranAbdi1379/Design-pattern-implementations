using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern.Classes
{
    public class Authenticator : Handler
    {
        public override void Handle(HttpRequest httpRequest)
        {
            var isValid = httpRequest.UserName == "admin" &&
                          httpRequest.Password == "1234";

           

            if (isValid)
            {
                Console.WriteLine("Authentication");
                HandleNext(httpRequest);
            }
                
        }
    }
}
