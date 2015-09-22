using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type=="cheese")
            {
                return new NYStyleCheesePizza();
            }
            //else if (type == "clam")
            //{
            //    return new NYStyleClamPizza();
            //}
            else
            {
                return null;
            }
        }
    }
}
