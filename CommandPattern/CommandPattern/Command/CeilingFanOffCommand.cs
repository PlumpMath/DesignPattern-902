using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CeilingFanOffCommand:Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.Off();
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
