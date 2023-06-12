using Common_pattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern.Classes
{
    public class AcceptButton : Button
    {
        public AcceptButton(ICommand command) : base(command)
        {
        }
    }
}
