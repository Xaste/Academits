using System;
using System.Collections.Generic;
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

        void ShowResultText(string text);

        string GetText();
    }
}
