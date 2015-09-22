using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChicagoStyleStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            //else if (type == "clam")
            //{
            //    return new ChicagoStyleClamPizza();
            //}
            else
            {
                return null;
            }
        }
    }
}
