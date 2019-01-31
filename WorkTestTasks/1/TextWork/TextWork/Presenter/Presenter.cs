using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextWork.Model;

namespace TextWork.Presenter
{
    public class Presenter
    {
        private readonly TextFormatter _textFormatter = new TextFormatter();
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;

            _view.ConvertText += (OnConvert);
        }

        private void OnConvert(object sender, EventArgs e)
        {
            _textFormatter.InputString = _view.GetText();

            if (ReferenceEquals(_textFormatter.InputString, null))
            {
                return;
            }

            _textFormatter.MinWordLength = _view.MinWordLength;

            _textFormatter.Convert(_textFormatter.InputString, _view.IsPunctuationDelete);

            _view.ShowResultText(_textFormatter.OutputString);
        }
    }
}
