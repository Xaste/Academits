using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.View
{
    public interface IView
    {
        int WithDrawSum { get; }

        int PreferNominal { get; }

        event EventHandler<ATMEventArgs> BankNoteAdded;

        event EventHandler<EventArgs> WithDraw;

        void UpdateATMLoading(Dictionary<int, int> loadout, int nominal);

        void SetReadyATM(IList<int> col);

        void SetBalance(int balance);

        void ShowMessage(string message, string caption);
    }
}
