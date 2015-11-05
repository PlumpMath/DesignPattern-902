using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage myTea = new Tea();
            myTea.PrepareRecipe();

            CaffeineBeverage myCoffee = new Coffee();
            myCoffee.PrepareRecipe();
            Console.ReadLine();


        }
    }
}
