using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWrok
{
    public interface IView
    {
        string InputFile { get; }

        string OutputFile { get; }

        bool IsPunctuationDelete { get; }

        int MinWordLength { get; }

        void ShowMessage(string message, string caption);

        event EventHandler<EventArgs> ConvertText;

        void ShowResultText(string text);

        string GetText();
    }
}
