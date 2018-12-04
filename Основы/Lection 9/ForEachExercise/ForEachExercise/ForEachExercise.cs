using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachExercise
{
    class ForEachExercise
    {
        static void Main(string[] args)
        {
            int arrayLength = 100;
            int[] array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            foreach (int e in array)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
