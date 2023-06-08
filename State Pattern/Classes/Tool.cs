using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.Classes
{
    public abstract class Tool
    {
        public string Name { get; set; }

        public abstract void MouseDown();
        public abstract void MouseUp();
    }
}
