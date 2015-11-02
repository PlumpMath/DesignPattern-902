using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CdPlayer
    {

        string description;
        int currentTrack;
        Amplifier amplifier;
        string title;

        public CdPlayer(string description, Amplifier amplifier)
        {
            this.description = description;
            this.amplifier = amplifier;
        }

        public void on()
        {
            Console.WriteLine(description + " on");
        }

        public void off()
        {
            Console.WriteLine(description + " off");
        }

        public void eject()
        {
            title = null;
            Console.WriteLine(description + " eject");
        }

        public void play(String title)
        {
            this.title = title;
            currentTrack = 0;
            Console.WriteLine(description + " playing \"" + title + "\"");
        }

        public void play(int track)
        {
            if (title == null)
            {
                Console.WriteLine(description + " can't play track " + currentTrack +
                        ", no cd inserted");
            }
            else
            {
                currentTrack = track;
                Console.WriteLine(description + " playing track " + currentTrack);
            }
        }

        public void stop()
        {
            currentTrack = 0;
            Console.WriteLine(description + " stopped");
        }

        public void pause()
        {
            Console.WriteLine(description + " paused \"" + title + "\"");
        }

        public string toString()
        {
            return description;
        }
    }
}
