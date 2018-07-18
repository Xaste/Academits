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

        public Range GetCrossRange(Range b)
        {
            if (this.To <= b.From || this.From >= b.To)
            {
                return null;
            }

            return new Range(Math.Max(this.From, b.From), Math.Min(this.To, b.To));
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

        public Range[] GetDifferenceRange(Range b)
        {
            if (this.To <= b.From || this.From >= b.To)
            {
                return new Range[] { new Range(this.From, this.To), null };
            }
            else if (this.From < b.From && this.To > b.To)
            {
                return new Range[] { new Range(this.From, b.From), new Range(b.To, this.To) };
            }
            else
            {
                double from = (this.From < b.From) ? this.From : b.To;
                double to = (this.To <= b.To) ? b.From : this.To;

                return new Range[] { new Range(from, to), null };
            }
        }
    }
}
