using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Classes
{
    public class HighContrastFilter : IFilter
    {
        public void ApplyFilter()
        {
            Console.WriteLine("High contrast filter is applied.");
        }
    }
}
