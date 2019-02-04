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

        event EventHandler<AtmEventArgs> BankNoteAdded;

        event EventHandler<BankNotesEventArgs> WithDraw;

        void UpdateAtmLoading(Dictionary<int, int> atmLoad, int nominal);

        void SetReadyAtm(IList<int> col);

        void ShowBalance(int balance);

        void ShowMessage(string message, string caption);
    }
}
