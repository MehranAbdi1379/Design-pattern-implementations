using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.Classes
{
    public class DrawTool : Tool
    {
        public override void MouseDown()
        {
            MessageBox.Show("Draw tool mouse down");
        }

        public override void MouseUp()
        {
            MessageBox.Show("Draw tool mouse down");
        }
    }
}
