using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy: CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            description = "Soy";
        }

        public override double cost()
        {
            return 0.10 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
    }
}
