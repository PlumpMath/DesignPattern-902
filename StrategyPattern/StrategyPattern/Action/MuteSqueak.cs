using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MuteSqueak:IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<slience>>");
        }
    }
}
