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
            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                while (!char.IsLetter(str[start]) && start < end)
                {
                    ++start;
                }

                while (!char.IsLetter(str[end]) && end > start)
                {
                    --end;
                }

                if (char.ToLower(str[start]) != char.ToLower(str[end]))
                {
                    return false;
                }

                ++start;
                --end;
            }
            return true;
        }
    }
}
