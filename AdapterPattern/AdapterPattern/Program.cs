using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says.......");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("The Duck says.......");
            testDuck(duck);

            Console.WriteLine("The TurkeyAdapter says...");
            testDuck(turkeyAdapter);

            Console.ReadLine();

        }

        static void testDuck(Duck duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
