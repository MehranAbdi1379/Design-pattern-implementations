using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern.Classes
{
    public class GenerateReportTask : Task
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void DoExecute()
        {
            Console.WriteLine("Report generated.");
        }
    }
}
