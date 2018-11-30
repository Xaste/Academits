using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    class TV
    {
        private string _location;

        public TV(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} TV is On");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} TV is Off");
        }
        public void SetInputChannel()
        {

        }

        public void SetVolume()
        {

        }
    }
}
