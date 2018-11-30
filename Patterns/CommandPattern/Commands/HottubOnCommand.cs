using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class HottubOnCommand : ICommand
    {
        Hottub _hottub;

        public HottubOnCommand(Hottub hottub)
        {
            _hottub = hottub;
        }
        public void ExecuteCommand()
        {
            _hottub.JetsOn();
        }

        public void UndoCommand()
        {
            _hottub.JetsOff();
        }
    }
}
