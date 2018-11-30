using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class StereoOnWithCDCommand : ICommand
    {
        private Stereo _stereo;
        
        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void ExecuteCommand()
        {
            _stereo.On();
            _stereo.SetCD();
            _stereo.SetVolume(11);
        }

        public void UndoCommand()
        {
            throw new NotImplementedException();
        }
    }
}
