using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.Classes
{
    public class DeleteTool : Tool
    {
        public override void MouseDown()
        {
            MessageBox.Show("Delete tool mouse down");
        }

        public override void MouseUp()
        {
            MessageBox.Show("Delete tool mouse up");
        }
    }
}
