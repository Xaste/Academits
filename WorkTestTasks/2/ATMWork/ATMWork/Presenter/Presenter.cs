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
        private readonly Atm _atm = new Atm(0, 100, 50);
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;
            _view.SetReadyAtm(_atm.AtmCurrentLoad.Keys.ToList());
            _view.UpdateAtmLoading(_atm.AtmCurrentLoad, _atm.MaxBankNotesCapacity);
            _view.SetBalance(_atm.Balance);

            _view.BankNoteAdded += new EventHandler<AtmEventArgs>(BankNoteAdd);
            //_view.BankNoteAdded += BankNoteAdd;
            _view.WithDraw += new EventHandler<EventArgs>(WithDraw);
        }

        private void BankNoteAdd(object sender, AtmEventArgs e)
        {
            _atm.AddBankNote(e.BankNoteNominal);

            _view.UpdateAtmLoading(_atm.AtmCurrentLoad, _atm.MaxBankNotesCapacity);

            _view.SetBalance(_atm.Balance);
        }

        private void WithDraw(object sender, EventArgs e)
        {
            if (_atm.Balance < _view.WithDrawSum)
            {
                _view.ShowMessage("Недостаточно средств!", "Ошибка!");
                return;
            }

            if (_view.WithDrawSum == 0)
            {
                _view.ShowMessage("Введите сумму изъятия!", "Ошибка!");
                return;
            }

            var result = _atm.CalculateWithDraw(_view.WithDrawSum, _view.PreferNominal);

            var withDrawAmount = 0;

            var sb = new StringBuilder();

            foreach (var pair in result)
            {
                sb.Append($"{pair.Key}р.: {pair.Value}шт, ");
                withDrawAmount += pair.Key * pair.Value;
            }

            sb.Append($"Выдано : {withDrawAmount}");

            _atm.Balance -= withDrawAmount;
            _view.SetBalance(_atm.Balance);
            _view.UpdateAtmLoading(_atm.AtmCurrentLoad, _atm.MaxBankNotesCapacity);

            _view.ShowMessage(sb.ToString(), "Готово");
        }
    }
}
