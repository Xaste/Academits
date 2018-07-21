using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExercise
{
    class RangeExercise
    {
        static void Main(string[] args)
        {
            var a = new Range(3, 8);
            var b = new Range(2, 10);

            var c = a.GetCrossRange(b);

            var array = a.GetSumRange(b);

            var array2 = a.GetDifferenceRange(b);

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
