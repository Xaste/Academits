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

            Experiment(outputString, isPunctuationDelete);

            for (var i = 0; i < outputString.Length;)
            {
                var removeLength = 0;
                var needContinue = false;

                while (i < outputString.Length && (!char.IsWhiteSpace(outputString[i]) && !char.IsPunctuation(outputString[i])))
                {
                    removeLength++;

                    if (removeLength > MinWordLength)
                    {
                        char k = 'x';
                        i = LastIndexOf(outputString, i, x => char.IsLetterOrDigit(x));

                        needContinue = true;
                        break;
                    }

                    i++;
                }

                if (needContinue)
                {
                    continue;
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

        public static int LastIndexOf(string str, int startindex, Func<char, bool> predicate)
        {
            var index = startindex;

            var t = predicate(' ');

            foreach (char item in str)
            {
                if (predicate(item))
                {
                    index++;
                }
                else
                {
                    return index;
                }

            }

            Console.WriteLine();

            if (index > startindex)
            {
                return index;
            }

            return -1;

        }

        public void Experiment(string InputFilePath, bool isPunctuationDelete)
        {
            using (var fs = File.Open(InputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var bs = new BufferedStream(fs, 1))
                {
                    using (StreamReader sr = new StreamReader(bs))
                    {
                        using (var sw = new StreamWriter("D:\\123_out.txt"))
                        {
                            var index = 0;
                            char[] block = null;
                            var sb = new StringBuilder();
                            while (sr.Peek() >= 0)
                            {
                                block = new char[MinWordLength + 1];

                                sr.Read(block, index, block.Length);
                                for (int i = 0; i < block.Length && char.IsLetterOrDigit(block[i]); i++)
                                {
                                    sb.Append(block[i]);
                                }

                                if (sb.Length >= MinWordLength)
                                {
                                    Console.WriteLine("Пишем в файл");
                                }
                                var removeLength = 0;
                                while (char.IsLetterOrDigit(block[i]))
                                {
                                    removeLength++;
                                }

                                if (removeLength == block.Length)
                                {
                                    sr.Read(block, block.Length - 1, MinWordLength);
                                }
                            }
                        }

                    }
                }
            }

            /*var splitStings = inputString.Split(' ', ',', '.', ':');
            foreach (var item in splitStings)
            {
                for (int i = 0; i < item.Length; i++)
                {

                }
            }
            for (var i = 0; i < splitStings.Length;)
            {
                var removeLength = 0;
                var needContinue = false;

                while (i < splitStings.Length && (!char.IsWhiteSpace(splitStings[i]) && !char.IsPunctuation(splitStings[i])))
                {
                    removeLength++;

                    if (removeLength > MinWordLength)
                    {
                        char k = 'x';
                        i = LastIndexOf(splitStings, i, x => char.IsLetterOrDigit(x));

                        needContinue = true;
                        break;
                    }

                    i++;
                }

                if (needContinue)
                {
                    continue;
                }

                if (removeLength > 0 && removeLength < MinWordLength)
                {
                    i -= removeLength;

                    splitStings = splitStings.Remove(i, removeLength);
                }
                else if (isPunctuationDelete && char.IsPunctuation(splitStings[i]))
                {
                    splitStings = splitStings.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }

            OutputString = splitStings;*/
        }

    }
}
