using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class MacroCommand : ICommand
    {
        private ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void ExecuteCommand()
        {
            foreach (var com in _commands)
            {
                com.ExecuteCommand();
            }
        }

        public void UndoCommand()
        {
            foreach (var com in _commands)
            {
                com.UndoCommand();
            }
        }
    }
}
