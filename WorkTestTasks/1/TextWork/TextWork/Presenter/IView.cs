using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWork.Presenter
{
    public interface IView
    {
        string InputFilePath { get; }

        string OutputFilePath { get; }

        bool IsPunctuationDelete { get; }

        int MinWordLength { get; }

        void ShowMessage(string message, string caption);

        event EventHandler<EventArgs> ConvertText;

        void ShowResultText(string text);

        string GetText();
    }
}
