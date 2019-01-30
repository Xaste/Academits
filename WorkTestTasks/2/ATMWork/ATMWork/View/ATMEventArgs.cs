using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.View
{
    public class AtmEventArgs : EventArgs
    {
        public int BankNoteNominal { get; }

        public AtmEventArgs(int amount)
        {
            BankNoteNominal = amount;
        }
    }
}
