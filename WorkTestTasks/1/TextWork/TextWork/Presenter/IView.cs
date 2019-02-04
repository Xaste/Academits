using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextWork.Presenter
{
    public interface IView
    {
        bool IsPunctuationDelete { get; }

        int MinWordLength { get; }

        event EventHandler<EventArgs> ConvertText;

        Stream GetInputTextStream();

        Stream GetOutputTextStream();

        void ShowMessage(string message, string caption);
    }
}
