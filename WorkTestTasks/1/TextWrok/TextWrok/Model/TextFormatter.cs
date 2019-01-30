using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextWrok
{
    class TextFormatter
    {
        public string InputFileName { get; set; }

        public string OutputFileName { get; set; }

        public string InputString { get; set; }

        public string OutputString { get; private set; }

        public int MinWordLength { get; set; }

        public void DeleteWords(string inputString)
        {
            var outputString = inputString;

            for (var i = 0; i < outputString.Length; i++)
            {
                var removeLength = 0;

                while (i < outputString.Length && (!char.IsWhiteSpace(outputString[i]) && !char.IsPunctuation(outputString[i])))
                {
                    removeLength++;
                    i++;
                }

                if (removeLength < MinWordLength)
                {
                    i -= removeLength;
                    outputString = outputString.Remove(i, removeLength);
                }
            }

            OutputString = outputString;
        }

        public void Convert(string inputString, bool isPunctuationDelete)//TODO
        {
            var outputString = inputString;

            for (var i = 0; i < outputString.Length; i++)
            {
                var removeLength = 0;

                while (i < outputString.Length && (!char.IsWhiteSpace(outputString[i]) && !char.IsPunctuation(outputString[i])))
                {
                    removeLength++;
                    i++;
                }



                if (removeLength < MinWordLength && removeLength > 0)
                {
                    i -= removeLength;

                    outputString = outputString.Remove(i, removeLength);
                }

                if (removeLength == 0 && isPunctuationDelete && char.IsPunctuation(outputString[i]))
                {
                    outputString.Remove(i, 1);
                }
                /*else if (isPunctuationDelete && char.IsPunctuation(outputString[i]))
                {
                    outputString = outputString.Remove(i, 1);
                    i--;
                }*/
            }

            OutputString = outputString;
        }

        public void RemovePunctuation(string inputString)
        {
            var outputString = inputString;

            for (var i = 0; i < outputString.Length; i++)
            {
                if (char.IsPunctuation(outputString[i]))
                {
                    outputString = outputString.Remove(i, 1);
                    i--;
                }
            }

            OutputString = outputString;
        }

        public void RemovePunctuationRegex(string inputString)
        {
            OutputString = Regex.Replace(inputString, @"[^\w\s]", "");
        }
    }
}
