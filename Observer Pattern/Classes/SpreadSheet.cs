using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Classes
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("SpreadSheet: " + value);
        }
    }
}
