using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern.Classes
{
    public class TransferMoneyTask : Task
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        public override void DoExecute()
        {
            Console.WriteLine("Transfer money.");
        }

    }
}
