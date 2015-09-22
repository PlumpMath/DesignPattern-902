using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
        }
    }
}
