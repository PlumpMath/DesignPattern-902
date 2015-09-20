using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type=="CheesePizza")
            {
                pizza = new CheesePizza();
            }
            else if (type == "ClamPizza")
            {
                pizza = new ClamPizza();
            }
            return pizza;
        }

    }
}
