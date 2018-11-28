using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class LigthOnCommand : ICommand
    {
        Light _light;

        public LigthOnCommand(Light light)
        {
            _light = light;
        }

        public void ExecuteCommand()
        {
            _light.On();
            Console.WriteLine("Light On");
        }
    }
}
