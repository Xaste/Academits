using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class GarageDoorDownCommand : ICommand
    {
        GarageDoor _garageDoor;

        public GarageDoorDownCommand(GarageDoor door)
        {
            _garageDoor = door;
        }

        public void ExecuteCommand()
        {
            _garageDoor.Down();
        }

        public void UndoCommand()
        {
            throw new NotImplementedException();
        }
    }
}
