using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeReverseArray
{
    class MakeReverseArray
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();

            ReverseArray(array);
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
        }

        public static void ReverseArray(int[] array)
        {

            for (int i = 0; i < array.Length / 2; i++)
            {
                int exchange = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = exchange;
            }
        }
    }
}
