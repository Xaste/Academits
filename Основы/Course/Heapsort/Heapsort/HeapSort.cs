using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class HeapSort
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 2, 3, 6, 8, 7, 1, 12 };
            int[] array2 = { 9, 4, 1, 8, 7, 6, 0, 9, 1, 22, 13, -1, 2, 9 };

            Sort(array);
            Sort(array2);

            foreach (int e in array)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            foreach (int e in array2)
            {
                Console.WriteLine(e);
            }
        }

        public static void Sort(int[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--)
            {
                Sifting(array, i, array.Length - 1);
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;
                if (i > 1)
                {
                    Sifting(array, 0, i - 1);
                }
            }
        }

        public static void Sifting(int[] array, int index, int endIndex)
        {
            while (index < (endIndex + 1) / 2)
            {
                int maxChild;
                int maxChildIndex;

                if (index * 2 + 2 > endIndex)
                {
                    maxChild = array[index * 2 + 1];
                    maxChildIndex = index * 2 + 1;
                }
                else
                {
                    maxChild = (array[index * 2 + 1] > array[index * 2 + 2]) ? array[index * 2 + 1] : array[index * 2 + 2];
                    maxChildIndex = (array[index * 2 + 1] > array[index * 2 + 2]) ? index * 2 + 1 : index * 2 + 2;
                }

                if (array[index] < maxChild)
                {
                    array[maxChildIndex] = array[index];
                    array[index] = maxChild;
                    index = maxChildIndex;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
