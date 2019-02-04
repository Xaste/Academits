using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.View
{
    public class BankNotesEventArgs : EventArgs
    {
        public List<int> BankNoteNominal { get; set; } = new List<int>();

    }
}
