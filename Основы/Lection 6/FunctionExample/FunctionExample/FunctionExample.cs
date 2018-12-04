using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExample
{
    class FunctionExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(2, 5));
            Console.WriteLine(Addition(3.7, 2.9));

            Console.Write("Введите первое число: ");
            int begin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите последнее число: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Среднее арифмитическое чисел с {begin} до {end}: {GetAverage(begin, end)}.");

            Console.WriteLine(GetMin(4, 7));
            Console.WriteLine(GetMin(6, 5));
            Console.WriteLine(GetMin(6, 6));

            Console.WriteLine(GetMax(4, 7));
            Console.WriteLine(GetMax(6, 5));
            Console.WriteLine(GetMax(6, 6));
        }

        public static double Addition(double a, double b)
        {
            return 3 * a + 4 * b;
        }

        public static double GetAverage(int begin, int end)
        {
            int sum = 0;
            int count = 0;
            for (int i = begin; i <= end; i++)
            {
                sum += i;
                ++count;
            }
            return (double)sum / count;
        }

        public static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
