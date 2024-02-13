using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator.CarDecorators
{
    public class HotWheelsCarDecorator : CarDecorator
    {
        private readonly Car _car;
        public HotWheelsCarDecorator(Car car)
        {
            _car = car;
        }
        public override decimal Cost()
        {
            return _car.Cost()+10;
        }

        public override string Description()
        {
            return _car.Description() + ", Hot Wheels";
        }

        public override int Speed()
        {
            return _car.Speed() + 30;
        }
    }
}
