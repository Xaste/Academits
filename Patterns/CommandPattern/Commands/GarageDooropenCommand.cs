﻿using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            _door = door;
        }

        public void ExecuteCommand()
        {
            _door.Up();
            Console.WriteLine("Garage Door is Open");
        }

        public void UndoCommand()
        {
            throw new NotImplementedException();
        }
    }
}
