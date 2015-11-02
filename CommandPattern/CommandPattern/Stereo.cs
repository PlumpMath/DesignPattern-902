using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stereo
    {
        string position;

        public Stereo(string position)
        {
            this.position = position;
        }
        public void on()
        {
            Console.WriteLine(position+" stereo is on");
        }
        public void off()
        {
            Console.WriteLine(position + " stereo is off");
        }
        public void setCD()
        {
            Console.WriteLine(position + " stereo is set for CD input");
        }
        public void setnDvd()
        {

        }
        public void setRadio()
        {

        }
        public void setVolume(int volume)
        {
            Console.WriteLine(position + " stereo volume set to " + volume.ToString());
        }
    }
}
