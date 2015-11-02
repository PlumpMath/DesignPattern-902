using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.High();
        }

        public void undo()
        {
            if (prevSpeed == CeilingFan.high)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == CeilingFan.medium)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == CeilingFan.low)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == CeilingFan.off)
            {
                ceilingFan.Off();
            }
        }
    }
}
