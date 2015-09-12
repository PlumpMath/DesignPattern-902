using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha:CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            description = "Mocha";
        }

        public override double cost()
        {
            return 0.20 + beverage.cost();
        }

        public override string getDescription()
        {
            return beverage.getDescription()+", Mocha";
        }
    }
}
