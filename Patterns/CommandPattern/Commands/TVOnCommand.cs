using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class TVOnCommand : ICommand
    {
        TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }
        public void ExecuteCommand()
        {
            _tv.On();
        }

        public void UndoCommand()
        {
            _tv.Off();
        }
    }
}
