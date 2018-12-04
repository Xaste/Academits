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
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите первое число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            int leastCommonDivisor = FindLeastCommonDivisor(first, second);
            Console.WriteLine(leastCommonDivisor);
            Console.ReadLine();
        }

        public static int FindLeastCommonDivisor(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return FindLeastCommonDivisor(b, a % b);
            }
        }
    }
}
