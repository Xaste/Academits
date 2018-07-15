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
            Range a = new Range(3, 8);
            Range b = new Range(3, 8);

            Range c = Range.GetCrossRange(a, b);

            Range[] array = Range.GetSumRange(a, b);
            //array = Range.GetSumRange(a, b);

            Range[] array2 = Range.GetDifferenceRange(a, b);
            //array2 = Range.GetDifferenceRange(a, b);

            Console.ReadLine();
        }
    }
}
