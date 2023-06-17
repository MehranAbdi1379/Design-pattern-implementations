using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern.Classes
{
    public class WebServer
    {
        private readonly Handler handler;

        public WebServer(Handler handler)
        {
            this.handler = handler;
        }

        public void Handle(HttpRequest httpRequest)
        {
            handler.Handle(httpRequest);
        }
    }
}
