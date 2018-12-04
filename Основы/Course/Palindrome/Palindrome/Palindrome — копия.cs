using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            Console.WriteLine(IsPalindrome(input));
            Console.ReadLine();
        }

        public static bool IsPalindrome(string str)
        {
            int separation1 = 0;
            int separation2 = 0;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (char.IsWhiteSpace(str[i + separation1]))
                {
                    ++separation1;
                }
                if (char.IsWhiteSpace(str[str.Length - 1 - i - separation2]))
                {
                    ++separation2;
                }

                if (char.ToLower(str[i + separation1]) == char.ToLower(str[str.Length - 1 - i - separation2]))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
