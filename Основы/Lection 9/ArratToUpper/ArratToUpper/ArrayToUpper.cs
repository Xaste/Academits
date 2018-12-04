using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayToUpper
{
    class ArrayToUpper
    {
        static void Main(string[] args)
        {
            string[] strings = { "the ", "quick ", "brown ", "fox ", "jumps ",
                            "over ", "the ", "lazy ", "dog ", "in ", "the ",
                            "barn " };
            foreach (string e in strings)
            {
                Console.Write(e);
            }
            Console.WriteLine();

            UpString(strings);
            foreach (string e in strings)
            {
                Console.Write(e);
            }
            Console.ReadLine();

        }
        public static void UpString(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i].ToUpper();
            }
        }
    }
}
