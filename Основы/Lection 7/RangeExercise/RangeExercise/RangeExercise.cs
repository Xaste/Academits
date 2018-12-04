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
            Range range = new Range(-3.4, 2.5);
            double length2 = range.GetLength();

            double x1 = -3.1;
            double x2 = 5;

            bool isInsideX1 = range.IsInside(x1);
            bool isInsideX2 = range.IsInside(x2);
        }
    }

    class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return From - To;
        }

        public bool IsInside(double a)
        {
            return a >= From && a <= To;
        }
    }
}
