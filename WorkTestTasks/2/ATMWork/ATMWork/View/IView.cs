using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.View
{
    interface IView
    {
        /*double Ballance { get; }

        void AddCash(double amount);

        void RemoveCash(double amount);*/

        event EventHandler<EventArgs> BankNoteAdded;
    }
}
