using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Preparing "+name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding Source");
            Console.WriteLine("Adding toppings: ");

            foreach (var item in toppings)
            {
                Console.WriteLine(" " + item);
            }

        }
        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("cutting the pizza into diagonal slices");
        }
        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }
    }
}
