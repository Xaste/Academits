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
        private const int ReadSize = 1024;

        public int MinWordLength { get; set; }

        public void Convert(Stream inputStream, Stream outputStream, bool isPunctuationDelete)
        {
            if (inputStream is null)
            {
                throw new ArgumentNullException("Ошибка при чтении исходного файла");
            }
            if (outputStream is null)
            {
                throw new ArgumentNullException("Ошибка при чтении файла для записи");
            }

            using (var reader = new StreamReader(inputStream, Encoding.Default))
            {
                using (var writer = new StreamWriter(outputStream))
                {
                    var sb = new StringBuilder();

                    var curMinLength = MinWordLength;

                    while (reader.Peek() >= 0)
                    {
                        var c = (char)reader.Read();

                        if (sb.Length >= ReadSize)
                        {
                            writer.Write(sb);
                            sb.Clear();
                            curMinLength = 0;
                        }

                        if (char.IsWhiteSpace(c) || char.IsPunctuation(c) || reader.Peek() < 0)
                        {
                            if (sb.Length >= curMinLength)
                            {
                                writer.Write(sb);
                                curMinLength = MinWordLength;
                            }

                            sb.Clear();

                            if (isPunctuationDelete && char.IsPunctuation(c))
                            {
                                continue;
                            }

                            writer.Write(c);
                            continue;
                        }
                        sb.Append(c);
                    }
                    sb.Clear();
                }
            }
        }
    }
}
