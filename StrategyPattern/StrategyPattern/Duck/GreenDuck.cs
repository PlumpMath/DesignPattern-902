using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class GreenDuck:Duck
    {
        public GreenDuck()
        {
            FlyBehavior = new FlyWithWing();
            QuackBehavior = new Squeak();
        }
    }
}
