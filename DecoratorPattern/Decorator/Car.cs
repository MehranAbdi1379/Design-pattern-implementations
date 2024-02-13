using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class Car
    {
        public abstract string Description();
        public abstract int Speed();
        public abstract decimal Cost();
    }
}
