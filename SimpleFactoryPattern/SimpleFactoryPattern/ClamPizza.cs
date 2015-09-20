using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class ClamPizza : Pizza
    {
        public override void bake()
        {
            Console.WriteLine("ClamPizza bake");
        }

        public override void box()
        {
            Console.WriteLine("ClamPizza box");
        }

        public override void cut()
        {
            Console.WriteLine("ClamPizza cut");
        }

        public override void prepare()
        {
            Console.WriteLine("ClamPizza prepare");
        }
    }
}
