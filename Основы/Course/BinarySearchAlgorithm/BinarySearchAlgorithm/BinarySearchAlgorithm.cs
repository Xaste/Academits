using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class BinarySearchAlgorithm
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для которого надо найти индекс: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] array = { 1, 5, 77, 12, 33, 17, -2, 55, 0 };
            int left = 0;
            int right = array.Length - 1;

            Array.Sort(array);

            int index = BinarySearchRecursive(array, left, right, x);
            int index2 = BinarySearch(array, x);

            Console.WriteLine(index);
            Console.WriteLine(index2);

        }

        public static int BinarySearchRecursive(int[] a, int left, int right, int x)
        {
            if (left > right)
            {
                return -1;
            }
            int middle = (right + left) / 2;
            if (a[middle] == x)
            {
                return middle;
            }
            else if (x > a[middle])
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
            return BinarySearchRecursive(a, left, right, x);
        }

        public static int BinarySearch(int[] a, int x)
        {
            int left = 0;
            int right = a.Length - 1;
            int middle = (left + right) / 2;

            while (x != a[middle])
            {

                if (x > a[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

                if (left > right)
                {
                    return -1;
                }
                middle = (left + right) / 2;
            }
            return middle;
        }
    }
}
