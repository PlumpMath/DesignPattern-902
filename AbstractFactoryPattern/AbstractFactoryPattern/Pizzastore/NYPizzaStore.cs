using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("NY Style Cheese Pizza");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("NY Style Clam Pizza");
            }

            return pizza;

        }
    }
}
