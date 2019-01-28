using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork
{
    public class ATMEventArgs : EventArgs
    {
        public int BankNoteNominal { get; }

        public ATMEventArgs(int amount)
        {
            BankNoteNominal = amount;
        }
    }
}
