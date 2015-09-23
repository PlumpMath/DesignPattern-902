using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            nyPizzaStore.orderPizza("cheese");
            nyPizzaStore.orderPizza("clam");

            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            chicagoPizzaStore.orderPizza("cheese");
            chicagoPizzaStore.orderPizza("clam");

            Console.ReadLine();
        }
    }
}
