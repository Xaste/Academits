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
            Range b = new Range(6, 10);

            Range c = a.GetCrossRange(b);

            Range[] array = a.GetSumRange(b);

            Range[] array2 = a.GetDifferenceRange(b);

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
