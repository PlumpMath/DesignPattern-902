using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOffWithCDCommand:Command
    {
        Stereo stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void execute()
        {
            stereo.off();
        }

        public void undo()
        {
            stereo.on();
            stereo.setCD();
            stereo.setVolume(11);
        }
    }
}
