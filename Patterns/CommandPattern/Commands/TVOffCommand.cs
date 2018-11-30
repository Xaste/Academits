using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class TVOffCommand : ICommand
    {
        TV _tv;

        public TVOffCommand(TV tv)
        {
            _tv = tv;
        }
        public void ExecuteCommand()
        {
            _tv.Off();
        }

        public void UndoCommand()
        {
            _tv.On();
        }
    }
}
