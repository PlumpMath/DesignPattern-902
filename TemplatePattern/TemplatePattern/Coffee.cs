using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            char answer = 'N';
            if (answer=='Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
