using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_pattern.Classes
{
    public abstract class Task
    {
        protected readonly AuditTrail auditTrail;

        public Task(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void Execute()
        {
            auditTrail.Record();
            DoExecute();
        }

        public abstract void DoExecute();
    }
}
