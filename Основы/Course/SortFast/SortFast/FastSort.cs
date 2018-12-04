using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastSort
{
    class FastSort
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 4, 1, 8, 7, 6, 0, 9, 1, 22, 13, -1, 2, 9 };
            SortFast(array, 0, array.Length - 1);
            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
        }

        public static void SortFast(int[] array, int left, int right)
        {
            if (right - left == 1)
            {
                return;
            }
            else if (right - left == 2)
            {
                if (array[left] > array[right])
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    return;
                }
                else
                {
                    return;
                }
            }

            int x = (array[left] + array[right]) / 2;
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (array[i] < x)
                {
                    ++i;
                }
                while (array[j] > x)
                {
                    --j;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i;
                    --j;
                }
            }

            if (i < right)
            {
                SortFast(array, i, right);
            }

            if (j > left)
            {
                SortFast(array, left, j);
            }
        }
    }
}
