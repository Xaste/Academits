using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCheck
{
    class SortCheck
    {
        static void Main(string[] args)
        {
            double[] firstArray = { 1, 2, 3.5, 4, 7.3, 82 };
            double[] secondArray = { 9.9, 8.2, 5, 0, -0.1 };
            double[] thirdArray = { 5, 3.2, 0.2, 55 };

            Console.WriteLine(IsDecreasingSorted(firstArray));
            Console.WriteLine(IsDecreasingSorted(secondArray));
            Console.WriteLine(IsDecreasingSorted(thirdArray));
            Console.WriteLine();

            Console.WriteLine(IsAscendingSorted(firstArray));
            Console.WriteLine(IsAscendingSorted(secondArray));
            Console.WriteLine(IsAscendingSorted(thirdArray));
            Console.WriteLine();

            Array.Sort(thirdArray);
            Console.WriteLine(IsDecreasingSorted(thirdArray));
            Console.WriteLine(IsAscendingSorted(thirdArray));
            Console.WriteLine();

            Array.Reverse(thirdArray);
            Console.WriteLine(IsDecreasingSorted(thirdArray));
            Console.WriteLine(IsAscendingSorted(thirdArray));
        }

        public static bool IsDecreasingSorted(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsAscendingSorted(double[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
