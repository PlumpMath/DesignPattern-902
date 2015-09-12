using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.getDescription()+ " $" + espresso.cost());

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Mocha(houseBlend);
            houseBlend= new Mocha(houseBlend);
            houseBlend = new Soy(houseBlend);
            Console.WriteLine(houseBlend.getDescription() + " $" + houseBlend.cost());

            Console.ReadLine();
        }
    }
}
