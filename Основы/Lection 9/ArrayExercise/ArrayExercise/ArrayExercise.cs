using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    class ArrayExercise
    {
        static void Main(string[] args)
        {
            int arrayLength = 100;
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();
        }
    }
}
