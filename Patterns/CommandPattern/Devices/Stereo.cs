using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    class Stereo
    {
        private string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        private int _volume = 5;

        public void On()
        {
            Console.WriteLine($"{_location} stereo is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} stereo is Off");
        }

        public void SetCD()
        {
            Console.WriteLine($"{_location} stereo is set for CD input");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{_location} stereo is set for DVD input");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{_location} stereo is set for Radio");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;

            Console.WriteLine($"{_location} stereo volume is set to {volume}");
        }
    }
}
