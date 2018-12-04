using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExample
{
    class ForExample
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 7; i <= 121; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 100; i >= 30; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int i = 100; i > 0; i--)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();

            Console.Write("Введите n: ");
            int last = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= last; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            Console.WriteLine();

            Console.Write("Введите х: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите х: ");
            last = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int count = 0;
            for (int i = first; i <= last; i++)
            {
                sum += i;
                ++count;
            }
            double average = (double)sum / count;
            Console.WriteLine($"Среднее арифмитическое чисел с {first} до {last}: {average}");
        }
    }
}
