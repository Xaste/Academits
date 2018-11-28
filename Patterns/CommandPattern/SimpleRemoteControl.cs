using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommandPattern.Commands;

namespace CommandPattern
{
    class SimpleRemoteControl
    {
        ICommand _slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.ExecuteCommand();
        }
    }
}
