using System;

namespace CommandPattern
{
    public class Light
    {
        string position;

        public Light(string position)
        {
            this.position = position;
        }
        public void on()
        {
            Console.WriteLine(position + " Light is on");
        }
        public void off()
        {
            Console.WriteLine(position + " Light is off");
        }
    }
}