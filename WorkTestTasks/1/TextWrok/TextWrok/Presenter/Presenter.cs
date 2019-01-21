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

            //_view.InputFileSelect += new EventHandler<EventArgs>(OnInputFileSet);

            //_view.OutputFileSelect += new EventHandler<EventArgs>(OnOutputFileSet);

            _view.ConvertText += new EventHandler<EventArgs>(OnConvert);
        }

        private bool IsValidatedFiles()
        {
            var result = true;

            if (!File.Exists(_view.InputFileName))
            {
                _view.ShowMessage("Неверно указан исходный файл.", "Ошибка!");
                result = false;
            }

            var a = File.Exists(_view.OutputFileName);

            if (!File.Exists(_view.OutputFileName))
            {
               
                _view.ShowMessage("Неверно указан итоговый(?) файл.", "Ошибка!");
                result = false;
            }

            return result;
        }

        /*private void OnInputFileSet(object sender, EventArgs e)//TODO Должно выполняться после нажатия на кнопку!
        {
            _model.InputFileName = _view.InputFileName;
            _model.InputString = File.ReadAllText(_view.InputFileName);
        }*/

        private void InputFileSet()
        {
            _model.InputFileName = _view.InputFileName;

            _model.InputString = File.ReadAllText(_view.InputFileName);
        }

        /*private void OnOutputFileSet(object sender, EventArgs e)
        {
            _model.OutputFileName = _view.OutputFileName;
        }*/

        private void OutputFileSet()
        {
            _model.OutputFileName = _view.OutputFileName;
        }

        private void OnConvert(object sender, EventArgs e)
        {

            if(IsValidatedFiles())
            {
                InputFileSet();
                OutputFileSet();

                _model.MinWordLength = _view.MinWordLength;

                _model.DeleteWords(_model.InputString);

                if (_view.IsPunctuationDelete)
                {
                    _model.RemovePunctuation(_model.OutputString);
                }

                try
                {
                    File.WriteAllText(_view.OutputFileName, _model.OutputString);
                }
                catch (UnauthorizedAccessException error)
                {
                    _view.ShowMessage(error.Message, "Ошибка!");

                    throw;
                }

                //File.WriteAllText(_view.OutputFileName, _model.OutputString);

                _view.ShowMessage("Конвертация текста выполненена.", "Готово!");
            }
        }
    }
}
