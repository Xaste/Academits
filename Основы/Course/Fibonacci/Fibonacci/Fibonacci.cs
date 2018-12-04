using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int first = 0;
            int second = 1;
            int sum = 0;

            while (i <= n)
            {
                sum = first + second;
                second = first;
                first = sum;
                ++i;
            }
            Console.WriteLine($"n={n}, fn = {sum}");
        }
    }
}
