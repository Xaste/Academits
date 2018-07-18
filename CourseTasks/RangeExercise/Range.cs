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
            if (a.To <= b.From || a.From >= b.To)
            {
                return null;
            }

            return new Range(Math.Max(a.From, b.From), Math.Min(a.To, b.To));
        }

        public static Range[] GetSumRange(Range a, Range b)
        {
            if (a.To < b.From || a.From > b.To)
            {
                return new Range[] { new Range(a.From, a.To), new Range(b.From, b.To) };
            }
            else
            {
                return new Range[] { new Range(Math.Min(a.From, b.From), Math.Max(b.To, a.To)), null };
            }
        }

        public static Range[] GetDifferenceRange(Range a, Range b)
        {
            if (a.To <= b.From || a.From >= b.To)
            {
                return new Range[] { new Range(a.From, a.To), null };
            }
            else if (a.From < b.From && a.To > b.To)
            {
                return new Range[] { new Range(a.From, b.From), new Range(b.To, a.To) };
            }
            else
            {
                double from = (a.From < b.From) ? a.From : b.To;
                double to = (a.To <= b.To) ? b.From : a.To;

                return new Range[] { new Range(from, to), null };
            }
        }
    }
}
