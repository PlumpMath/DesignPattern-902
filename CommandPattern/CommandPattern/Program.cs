using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();

            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();

            remote.setCommand(garageOpen);
            remote.buttonWasPressed();

            Console.ReadLine();
        }
    }
}
