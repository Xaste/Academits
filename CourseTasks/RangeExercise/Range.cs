using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExercise
{
    public class Range
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

        public Range[] GetSumRange(Range b)
        {
            if (this.To < b.From || this.From > b.To)
            {
                return new Range[] { new Range(this.From, this.To), new Range(b.From, b.To) };
            }
            else
            {
                return new Range[] { new Range(Math.Min(this.From, b.From), Math.Max(b.To, this.To)) };
            }
        }

        public Range[] GetDifferenceRange(Range b)
        {
            if (this.To <= b.From || this.From >= b.To)
            {
                return new Range[] { new Range(this.From, this.To) };
            }
            else if (this.From < b.From && this.To > b.To)
            {
                return new Range[] { new Range(this.From, b.From), new Range(b.To, this.To) };
            }
            else if (this.From == b.From && this.To == b.To)
            {
                return null;
            }
            else
            {
                double from = (this.From < b.From) ? this.From : b.To;
                double to = (this.To <= b.To) ? b.From : this.To;

                return new Range[] { new Range(from, to) };
            }
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Range)
            {
                Range range = (Range)obj;
                return (this.From == range.From && this.To == range.To);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return From.GetHashCode() + To.GetHashCode();
        }
    }
}
