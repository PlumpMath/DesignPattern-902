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

            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            nyPizzaStore.orderPizza("cheese");

            Console.ReadLine();
        }
    }
}
