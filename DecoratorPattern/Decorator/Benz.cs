using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class Benz : Car
    {
        public override decimal Cost()
        {
            return 150M;
        }

        public override string Description()
        {
            return "Benz";
        }

        public override int Speed()
        {
            return 350;
        }
    }
}
