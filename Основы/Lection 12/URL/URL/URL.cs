using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
    class URL
    {
        static void Main(string[] args)
        {
            string input = "https://SomeServerName/abcd/dfdf.htm?dfdf=dfdf";

            string serverName = GetServerNameFromURL(input);

            if (serverName == null)
            {
                Console.WriteLine("Что-то пошло не так...");
            }
            else
            {
                Console.WriteLine(serverName);
            }
        }

        public static string GetServerNameFromURL(string input)
        {
            int left = input.IndexOf("://");

            if (left == -1)
            {
                return null;
            }

            left += 3;
            int right = input.IndexOf("/", left);

            if (right == -1)
            {
                right = input.Length;
            }

            int length = right - left;

            return input.Substring(left, length);
        }
    }

}
