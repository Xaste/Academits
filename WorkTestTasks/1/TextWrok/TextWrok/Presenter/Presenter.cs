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

        private void GetText()
        {
            _model.InputString = _view.GetText();
        }

        /*private void OutputFileSet()
        {
            _model.OutputFileName = _view.OutputFileName;
        }*/

        private void OnConvert(object sender, EventArgs e)
        {

            //if (IsValidatedFiles())
            //{
            try
            {
                GetText();
            }
            catch (FileNotFoundException)
            {
                _view.ShowMessage("Не найден исходный файл", "Ошибка!");                
                return;
            }
            catch (UnauthorizedAccessException)
            {
                _view.ShowMessage("Нет доступа к  исходному файлу", "Ошибка!");
                return;
            }
            catch (Exception)
            {
                throw;
            }

            _model.MinWordLength = _view.MinWordLength;

            _model.DeleteWords(_model.InputString);

            if (_view.IsPunctuationDelete)
            {
                _model.RemovePunctuation(_model.OutputString);
            }

            try
            {
                _view.ShowResultText(_model.OutputString);
            }
            catch (FileNotFoundException)
            {
                _view.ShowMessage("Не найден файл для записи результата", "Ошибка!");
                return;
                
            }
            catch(UnauthorizedAccessException)
            {
                _view.ShowMessage("Нет доступа к файлу для записи результата", "Ошибка!");
                return;
            }
            catch(Exception)
            {
                throw;
            }
            _view.ShowResultText(_model.OutputString);

            _view.ShowMessage("Конвертация текста выполненена.", "Готово!");
            //}
        }
    }
}
