using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class CheesePizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("CheesePizza bake");
        }

        public override void box()
        {
            Console.WriteLine("CheesePizza box");
        }

        public override void cut()
        {
            Console.WriteLine("CheesePizza cut");
        }

        public override void prepare()
        {
            Console.WriteLine("CheesePizza prepare");
        }
    }
}
