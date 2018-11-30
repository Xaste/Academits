using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Devices
{
    class GarageDoor
    {
        private string _locaqtion;

        public GarageDoor(string location)
        {
            _locaqtion = location;
        }

        public void Up()
        {
            Console.WriteLine($"{_locaqtion} garage Door is Up");
        }

        public void Down()
        {
            Console.WriteLine($"{_locaqtion} garage Door is Down");
        }

        public void Stop()
        {

        }

        public void LightOn()
        {

        }

        public void LightOff()
        {

        }
    }
}
