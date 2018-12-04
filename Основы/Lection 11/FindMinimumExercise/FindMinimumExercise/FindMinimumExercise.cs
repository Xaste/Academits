using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMinimumExercise
{
    class FindMinimumExercise
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 2, 4, 55, 17, 8, 9, 22 };

            int minInArray = GetMinimumFromArray(array);
            Console.WriteLine(minInArray);
            Console.WriteLine();

            int minInArrayIndex = GetIndexOfMinimumInArray(array);
            Console.WriteLine(minInArrayIndex);
            Console.WriteLine();

            int minInArrayIndex2 = GetIndexOfMinimumInArray(array, 4);
            Console.WriteLine(minInArrayIndex2);

            Console.ReadLine();
        }

        public static int GetMinimumFromArray(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int GetIndexOfMinimumInArray(int[] array)
        {
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[index])
                {
                    index = i;
                }
            }
            return index;
        }

        public static int GetIndexOfMinimumInArray(int[] array, int start)
        {
            int index = start;

            for (int i = start; i < array.Length; i++)
            {
                if (array[i] < array[index])
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
