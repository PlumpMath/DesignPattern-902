using CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;

        public void execute()
        {
            Console.WriteLine("Garage Door is Open");
        }
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
    }
}
