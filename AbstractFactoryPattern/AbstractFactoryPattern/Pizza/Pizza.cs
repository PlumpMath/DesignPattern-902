using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Pizza
    {
        protected string name;
        protected IDough dough;
        protected ISauce sauce;


        public abstract void prepare();

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

        public void setName(string name)
        {
            this.name = name;
        }

        public void toString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("---- " + name + " ----\n");


            if (dough != null)
            {

                result.Append(dough);

                result.Append("\n");

            }

            if (sauce != null)
            {

                result.Append(sauce);

                result.Append("\n");

            }

            Console.WriteLine(result.ToString());
        }

    }
}
