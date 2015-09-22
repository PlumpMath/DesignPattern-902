using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {


        public IDough createDough()
        {
            return new ThinCrustDough();
        }

      
        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }
    }
}
