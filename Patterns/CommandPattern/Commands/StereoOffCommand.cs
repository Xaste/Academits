using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class StereoOffCommand : ICommand
    {
        Stereo _stero;

        public StereoOffCommand(Stereo stereo)
        {
            _stero = stereo;
        }

        public void ExecuteCommand()
        {
            _stero.Off();
        }

        public void UndoCommand()
        {
            _stero.On();
        }
    }
}
