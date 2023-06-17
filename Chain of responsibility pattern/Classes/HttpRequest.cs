using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern.Classes
{
    public class HttpRequest
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public HttpRequest(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
