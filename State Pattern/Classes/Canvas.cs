using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.Classes
{
    public class Canvas
    {
        public Tool Tool { get; set; } = new SelectionTool();

        public void MouseDown()
        {
            Tool.MouseDown();
        }

        public void MouseUp()
        {
            Tool.MouseUp();
        }
    }
}
