using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class CeilingFanOnCommand : ICommand
    {
        CeilingFan _fan;

        public CeilingFanOnCommand(CeilingFan fan)
        {
            _fan = fan;
        }
        public void ExecuteCommand()
        {
            _fan.High();
        }

        public void UndoCommand()
        {
            _fan.Off();
        }
    }
}
