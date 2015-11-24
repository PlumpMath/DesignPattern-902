using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFan
    {
        public static int high = 3;
        public static int medium = 2;
        public static int low = 1;
        public static int off = 0;
        string location;
        int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = off;
        }
        public void High()
        {
            speed = high;
            Console.WriteLine(location+ " ceiling fan is on hight.");
        }
        public void Medium()
        {
            speed = medium;
            Console.WriteLine(location + " ceiling fan is on medium.");
        }
        public void Low()
        {
            speed = low;
            Console.WriteLine(location + " ceiling fan is on low.");
        }
        public void Off()
        {
            speed = off;
            Console.WriteLine(location + " ceiling fan is off.");
        }
        public int getSpeed()
        {
            return speed;
        }
    }
}
