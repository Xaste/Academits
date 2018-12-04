using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclideanAlgorithm
{
    class EuclideanAlgorithm
    {
        static void Main(string[] args)
        {
            Console.Write("Введите а: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first == 0 && second == 0)
            {
                Console.WriteLine($"НОД = {first + second}");
            }
            else
            {
                if (second == 0)
                {
                    second = first;
                    first = 0;
                }
                while (first % second != 0)
                {
                    int exchange = first % second;
                    first = second;
                    second = exchange;
                }
            }

            Console.WriteLine($"НОД = {second}");
        }
    }
}
