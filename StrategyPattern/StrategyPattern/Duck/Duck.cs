using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior;
        public IQuackBehavior QuackBehavior;


        public void PeformaneFly()
        {
            FlyBehavior.Fly();
        }
        public void PeformaneQuack()
        {
            QuackBehavior.Quack();
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }
    }
}
