using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    class Light
    {
        private string _location = "";

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine($"{_location} light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{_location} light is off");
        }
    }
}
