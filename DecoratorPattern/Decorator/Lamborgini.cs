using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class Lamborgini : Car
    {
        public override int Speed()
        {
            return 250;
        }

        public override decimal Cost()
        {
            return 100M;
        }

        public override string Description()
        {
            return "Lamborgini";
        }
    }
}
