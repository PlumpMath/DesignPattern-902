using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public virtual void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void Brew();

        public abstract void AddCondiments();

    }
}
