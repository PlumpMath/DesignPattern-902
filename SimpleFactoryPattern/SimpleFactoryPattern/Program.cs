using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var factory = new SimplePizzaFactory();

            var pizzaStore = new PizzaStore(factory);
            pizzaStore.orderPizza("CheesePizza");
            pizzaStore.orderPizza("ClamPizza");
            Console.ReadLine();
        }
    }
}
