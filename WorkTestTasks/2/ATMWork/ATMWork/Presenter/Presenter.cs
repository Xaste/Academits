using ATMWork.Model;
using ATMWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.Presenter
{
    public class Presenter
    {
        private readonly ATM _aTM = new ATM(100,50);
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;
            _view.SetReadyATM(_aTM._aTMLoadOut.Keys.ToArray());
            _view.UpdateATMLoading(_aTM._aTMLoadOut, _aTM.MaxBankNotes);
            _view.SetBalance(_aTM.Balance);

            _view.BankNoteAdded += new EventHandler<ATMEventArgs>(BankNoteAdd);
            _view.WithDraw += new EventHandler<EventArgs>(WithDraw);
        }

        private void BankNoteAdd(object sender, ATMEventArgs e)
        {
            _aTM.AddBankNote(e.BankNoteNominal);

            _view.UpdateATMLoading(_aTM._aTMLoadOut, _aTM.MaxBankNotes);

            _view.SetBalance(_aTM.Balance);
        }

        private void WithDraw(object sender, EventArgs e)
        {
            if (_aTM.Balance < _view.WithDrawSum)
            {
                _view.ShowMessage("Недостаточно средств!", "Ошибка!");
                return;
            }

            if (_view.WithDrawSum == 0)
            {
                _view.ShowMessage("Введите сумму изъятия!", "Ошибка!");
                return;
            }

            var result =_aTM.CalculateWithDraw(_view.WithDrawSum, _view.PreferNominal);

            var withDrawAmount = 0;

            var sb = new StringBuilder();

            foreach (var pair in result)
            {
                sb.Append($"{pair.Key}р: {pair.Value}шт, ");
                withDrawAmount += pair.Key * pair.Value;
            }

            sb.Append($"Выдано : {withDrawAmount}");

            _aTM.Balance -= withDrawAmount;
            _view.SetBalance(_aTM.Balance);
            _view.UpdateATMLoading(_aTM._aTMLoadOut, _aTM.MaxBankNotes);

            _view.ShowMessage(sb.ToString(), "Готово");

        }
    }
}
