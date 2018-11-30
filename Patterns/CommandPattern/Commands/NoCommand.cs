using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class NoCommand : ICommand
    {
        public void ExecuteCommand()
        {
            
        }

        public void UndoCommand()
        {
            throw new NotImplementedException();
        }
    }
}
