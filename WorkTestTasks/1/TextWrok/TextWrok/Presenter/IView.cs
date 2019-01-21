using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWrok
{
    public interface IView
    {
        string InputFileName { get; }

        string OutputFileName { get; }

        bool IsPunctuationDelete { get; }

        int MinWordLength { get; }

        void ShowMessage(string message, string caption);

        //event EventHandler<EventArgs> InputFileSelect;

        //event EventHandler<EventArgs> OutputFileSelect;

        event EventHandler<EventArgs> ConvertText;
    }
}
