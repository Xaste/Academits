using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class RemoteControl
    {
        ICommand[] _onCommands;
        ICommand[] _offCommands;
        ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].ExecuteCommand();
            _undoCommand = _onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].ExecuteCommand();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.UndoCommand();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n------ Remote Control ------\n");

            for (int i = 0; i < _onCommands.Length; i++)
            {
                sb.Append($"[slot {i}] {_onCommands[i].GetType().Name}     {_offCommands[i].GetType().Name} \n");
            }

            sb.Append($"[undo] {_undoCommand.GetType().Name} \n");
            return sb.ToString();
        }
    }
}
