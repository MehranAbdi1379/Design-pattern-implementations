using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility_pattern.Classes
{
    public abstract class Handler
    {
        public Handler Next { get; set; }

        public abstract void Handle(HttpRequest httpRequest);
        public void HandleNext(HttpRequest httpRequest)
        {
            if(Next != null)
                Next.Handle(httpRequest);
        }
        public void AddToEndOfTheChain(Handler handler)
        {
            var endOfTheChain = this;
            while(endOfTheChain.Next != null)
            {
                endOfTheChain = endOfTheChain.Next;
            }

            endOfTheChain.Next = handler;
        }
    }
}
