using ATMWork.Model;
using ATMWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMWork.Presenter
{
    class Presenter
    {
        private readonly ATM _aTM = new ATM(100);
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;
        }

        private void AddBankNote()
        {
            //_aTM.AddCash()
        }
    }
}
