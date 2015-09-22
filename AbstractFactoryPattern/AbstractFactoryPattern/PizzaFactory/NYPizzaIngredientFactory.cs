using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {

        public IDough createDough()
        {
            return new ThickCrustDough();
        }

      
        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

    }
}
