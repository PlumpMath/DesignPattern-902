using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            if (type == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");
            }
            else if (type == "clam")
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");
            }

            return pizza;

        }
    }
}
