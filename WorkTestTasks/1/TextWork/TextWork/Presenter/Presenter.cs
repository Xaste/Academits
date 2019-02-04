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
            _textFormatter.MinWordLength = _view.MinWordLength;

            var inputStream = _view.GetInputTextStream();

            if (inputStream is null)
            {
                return;
            }

            var outputStream = _view.GetOutputTextStream();

            if (outputStream is null)
            {
                inputStream.Dispose();
                return;
            }

            try
            {
                _textFormatter.Convert(inputStream, outputStream, _view.IsPunctuationDelete);
                _view.ShowMessage("Конвертация текста выполнена!", "Готово!");
            }
            catch (IOException exception)
            {
                _view.ShowMessage(exception.Message, "Ошибка!");
            }
            catch (UnauthorizedAccessException exception)
            {
                _view.ShowMessage(exception.Message, "Ошибка!");
            }
            finally
            {
                inputStream.Dispose();
                outputStream.Dispose();
            }
        }
    }
}
