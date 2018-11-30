using CommandPattern.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class CeilingFanLowCommand
    {
        private CeilingFan _ceilingFan;
        private int _prevSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void ExecuteCommand()
        {
            _prevSpeed = _ceilingFan.GetSpeed();
            _ceilingFan.Low();
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
