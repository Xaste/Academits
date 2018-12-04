using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 4, 1, 8, 7, 6, 0, 9, 1, 22, 13, -1, 2, 9 };
            SortInsertion(array);

            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
        }

        public static void SortInsertion(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    --j;
                }
                array[j + 1] = temp;
            }
        }
    }
}
