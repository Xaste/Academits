using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubstring
{
    class MaxSubstring
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();

            Console.WriteLine($"Максимальная длина подстроки: {GetMaxSubstringLenght(inputString)}");
            Console.ReadLine();
        }

        public static int GetMaxSubstringLenght(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }

            int length = 1;
            int maxLength = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (char.ToLower(str[i - 1]) == char.ToLower(str[i]))
                {
                    ++length;
                }
                else
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                    }
                    length = 1;
                }
            }
            if (length > maxLength)
            {
                maxLength = length;
            }
            return maxLength;
        }
    }
}
