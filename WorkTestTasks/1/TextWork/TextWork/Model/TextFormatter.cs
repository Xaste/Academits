using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextWork.Model
{
    public class TextFormatter
    {
        private int _minWordlength;

        private const int ReadSize = 1024;

        public int MinWordLength
        {
            get => _minWordlength;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Длина слова не может быть отрицательной");
                }

                _minWordlength = value;
            }
        }

        public void Convert(Stream inputStream, Stream outputStream, bool isPunctuationDelete)
        {
            if (inputStream is null)
            {
                throw new ArgumentNullException("Input Stream is null");
            }
            if (outputStream is null)
            {
                throw new ArgumentNullException("Output Stream is null");
            }

            using (var reader = new StreamReader(inputStream, Encoding.Default))
            {
                using (var writer = new StreamWriter(outputStream, Encoding.Default))
                {
                    var sb = new StringBuilder();

                    var curMinLength = MinWordLength;

                    while (reader.Peek() >= 0)
                    {
                        if (sb.Length >= ReadSize)
                        {
                            writer.Write(sb);
                            sb.Clear();
                            curMinLength = 0;
                        }

                        var c = (char)reader.Read();

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
                }
            }
        }
    }
}
