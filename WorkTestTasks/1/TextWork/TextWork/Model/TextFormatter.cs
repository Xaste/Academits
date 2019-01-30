using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextWork.Model
{
    class TextFormatter
    {
        public string InputString { get; set; }

        public string OutputString { get; private set; }

        public int MinWordLength { get; set; }

        public void Convert(string inputString, bool isPunctuationDelete)
        {
            var outputString = inputString;

            for (var i = 0; i < outputString.Length;)
            {
                var removeLength = 0;

                while (i < outputString.Length && (!char.IsWhiteSpace(outputString[i]) && !char.IsPunctuation(outputString[i])))
                {
                    removeLength++;
                    i++;
                }

                if (removeLength > 0 && removeLength < MinWordLength)
                {
                    i -= removeLength;

                    outputString = outputString.Remove(i, removeLength);
                }
                else if (isPunctuationDelete && char.IsPunctuation(outputString[i]))
                {
                    outputString = outputString.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            OutputString = outputString;
        }
    }
}
