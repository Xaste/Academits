using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class StereoOnCommand : ICommand
    {
        Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void ExecuteCommand()
        {
            _stereo.On();
        }

        public void UndoCommand()
        {
            _stereo.Off();
        }
    }
}
