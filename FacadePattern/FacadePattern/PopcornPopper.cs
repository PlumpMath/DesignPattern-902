using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class PopcornPopper
    {
        string description;

        public PopcornPopper(string description)
        {
            this.description = description;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void pop()
        {
            Console.WriteLine(description + " popping popcorn!");
        }


        public string toString()
        {
            return description;
        }
    }
}
