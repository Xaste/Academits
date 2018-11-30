using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class CeilingFanOffCommand : ICommand
    {
        CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanOffCommand(CeilingFan fan)
        {
            _ceilingFan = fan;
        }
        public void ExecuteCommand()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Off();
        }

        public void UndoCommand()
        {
            if (_prevSpeed == CeilingFan.HIGH)
            {
                _ceilingFan.High();
            }
            else if (_prevSpeed == CeilingFan.MEDIUM)
            {
                _ceilingFan.Medium();
            }
            else if (_prevSpeed == CeilingFan.LOW)
            {
                _ceilingFan.Low();
            }
            else if (_prevSpeed == CeilingFan.OFF)
            {
                _ceilingFan.Off();
            }
        }
    }
}
