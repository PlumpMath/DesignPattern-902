using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck greenDuck = new GreenDuck();
            greenDuck.PeformaneFly();
            greenDuck.PeformaneQuack();

            Duck modelDuck = new ModelDuck();
            modelDuck.PeformaneFly();
            modelDuck.PeformaneQuack();

            modelDuck.setFlyBehavior(new FlyWithWing());
            modelDuck.setQuackBehavior(new MuteSqueak());
            modelDuck.PeformaneFly();
            modelDuck.PeformaneQuack();

            Console.ReadLine();
        }
    }
}
