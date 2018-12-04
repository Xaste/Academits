using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumInArray
{
    class MaximumInArray
    {
        static void Main(string[] args)
        {
            double[] array = { 4.3, 2.4, 17, -3.5, 4.99 };
            Console.WriteLine(GetMaximumFromArray(array));
        }

        public static double GetMaximumFromArray(double[] array)
        {
            double max = array[0];
            foreach (double e in array)
            {
                if (e > max)
                {
                    max = e;
                }
            }
            return max;
        }
    }
}
