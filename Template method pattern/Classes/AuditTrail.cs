using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern.Classes
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audited.");
        }
    }
}
