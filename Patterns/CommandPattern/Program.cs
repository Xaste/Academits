using CommandPattern.Devices;
using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();

            var light = new Light();
            var garageDoor = new GarageDoor();

            var lightOnCommand = new LigthOnCommand(light);
            var garageOpenCommand = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}
