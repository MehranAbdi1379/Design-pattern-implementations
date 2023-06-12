using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.Classes
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Chart: " + value);
        }
    }
}
