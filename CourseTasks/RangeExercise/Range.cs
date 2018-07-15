using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExercise
{
    class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public Range()
        {

        }

        public double GetLength()
        {
            return From - To;
        }

        public bool IsInside(double a)
        {
            return a >= From && a <= To;
        }

        public static Range GetCrossRange(Range a, Range b)
        {
            if (a.To < b.From || a.From > b.To)
            {
                return null;
            }

            Range answer = new Range
            {
                From = a.From > b.From ? a.From : b.From,
                To = a.To < b.To ? a.To : b.To
            };

            return answer;
        }
    }
}
