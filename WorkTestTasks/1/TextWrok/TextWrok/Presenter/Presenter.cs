using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWrok
{
    public class Presenter
    {
        private readonly TextFormatter _model = new TextFormatter();
        private readonly IView _view;

        public Presenter(IView view)
        {
            _view = view;

            _view.ConvertText += new EventHandler<EventArgs>(OnConvert);
        }

        private bool IsValidatedFiles()//TODO Не используется удалить!
        {
            var result = true;

            if (!File.Exists(_view.InputFile))
            {
                _view.ShowMessage("Неверно указан исходный файл.", "Ошибка!");
                result = false;
            }

            var a = File.Exists(_view.OutputFile);

            if (!File.Exists(_view.OutputFile))
            {

                _view.ShowMessage("Неверно указан итоговый(?) файл.", "Ошибка!");
                result = false;
            }

            return result;
        }

        private void GetText()
        {
            _model.InputString = _view.GetText();
        }

        private void OnConvert(object sender, EventArgs e)
        {
            _model.InputString = _view.GetText();

            if (ReferenceEquals(_model.InputString, null))
            {
                return;
            }

            _model.MinWordLength = _view.MinWordLength;

            /*_model.DeleteWords(_model.InputString);

            if (_view.IsPunctuationDelete)
            {
                _model.RemovePunctuation(_model.OutputString);
            }*/

            _model.Convert(_model.InputString, _view.IsPunctuationDelete);

            _view.ShowResultText(_model.OutputString);
        }
    }
}
