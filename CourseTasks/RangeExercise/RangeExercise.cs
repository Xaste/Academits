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
            Range b = new Range(8, 10);

            Range c = Range.GetCrossRange(a, b);

            Range[] array;
            array = Range.GetSumRange(a, b);

            Console.ReadLine();
        }
    }
}
