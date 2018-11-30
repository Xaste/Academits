using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class HottubOffCommand : ICommand
    {
        Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void ExecuteCommand()
        {
            _hottub.JetsOff();
        }

        public void UndoCommand()
        {
            _hottub.JetsOn();
        }
    }
}
