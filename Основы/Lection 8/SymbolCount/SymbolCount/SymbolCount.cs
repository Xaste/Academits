using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymbolCount
{
    class SymbolCount
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();

            Console.WriteLine($"Количество букв в строке: {GetLettersCount(inputString)}");
            Console.WriteLine($"Количество цифр в строке: {GetDigitsCount(inputString)}");
            Console.WriteLine($"Количество пробелов в строке: {GetSpaceCount(inputString)}");
            Console.WriteLine($"Количество остальных символов в строке: {inputString.Length - (GetDigitsCount(inputString) + GetSpaceCount(inputString) + GetLettersCount(inputString))}");

            Console.ReadLine();
        }

        public static int GetLettersCount(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static int GetDigitsCount(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }

        public static int GetSpaceCount(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsWhiteSpace(str[i]))
                {
                    ++count;
                }
            }
            return count;
        }
    }
}
