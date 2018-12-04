using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 4, 1, 8, 7, 6, 0, 9, 1, 22, 13, -1, 2, 9 };

            SortBubble(array);

            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
        }

        public static void SortBubble(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool isAlreadySorted = true;

                for (int j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;

                        isAlreadySorted = false;
                    }
                }

                if (isAlreadySorted)
                {
                    return;
                }
            }
        }
    }
}
