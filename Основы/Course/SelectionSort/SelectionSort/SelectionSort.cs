using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 4, 1, 8, 7, 6, 9, 1, 22, 13, -1, 2, 9 };
            SortSelection(array);

            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
        }

        public static void SortSelection(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = array[i];
                int index = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = min;
            }
        }
    }
}
