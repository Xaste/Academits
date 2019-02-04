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
        public int MinWordLength { get; set; }

        public void Convert(Stream inputStream, Stream outputStream, bool isPunctuationDelete)
        {
            if (ReferenceEquals(inputStream, null))
            {
                throw new ArgumentNullException("Ошибка при чтении исходного файла");
            }
            if (ReferenceEquals(outputStream, null))
            {
                throw new ArgumentNullException("Ошибка при чтении файла для записи");
            }

            using (var sr = new StreamReader(inputStream))
            {
                using (var sw = new StreamWriter(outputStream))
                {
                    var sb = new StringBuilder();

                    while (sr.Peek() >= 0)
                    {
                        var c = (char)sr.Read();

                        if (char.IsWhiteSpace(c) || char.IsPunctuation(c))
                        {
                            if (sb.Length >= MinWordLength)
                            {
                                sw.Write(sb.ToString());
                            }

                            sb.Clear();

                            if (isPunctuationDelete && char.IsPunctuation(c))
                            {
                                continue;
                            }
                            sw.Write(c);

                            continue;
                        }

                        sb.Append(c);
                    }
                }
            }
        }
    }
}
