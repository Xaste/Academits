using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElementInArray
{
    class FindElementInArray
    {
        static void Main(string[] args)
        {
            double[] array = { 17, 22.2, 13.2, 7, -1 };

            Console.Write("Введите значение для поиска: ");
            double value = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(GetIndexOfValue(array, value));
            Console.WriteLine(Array.IndexOf(array, value));
        }

        public static int GetIndexOfValue(double[] array, double value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
