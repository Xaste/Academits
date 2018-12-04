using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            double[] array = { 3.2, 3.7, 5, -3, 4, 6, 10, 6.2 };
            Console.WriteLine(GetEvenNumbersAverage(array));
        }

        public static double GetEvenNumbersAverage(double[] array)
        {
            int count = 0;
            double sum = 0;
            foreach (double e in array)
            {
                if (e % 2 == 0)
                {
                    sum += e;
                    ++count;
                }
            }
            return sum / count;
        }
    }
}
