using CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorCloseCommand : Command
    {
        GarageDoor garageDoor;

        public void execute()
        {
            garageDoor.down();
        }

        public void undo()
        {
            garageDoor.up();
        }

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
    }
}
