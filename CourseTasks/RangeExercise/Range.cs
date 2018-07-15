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
                From = (a.From > b.From) ? a.From : b.From,
                To = (a.To < b.To) ? a.To : b.To
            };

            return answer;
        }

        public static Range[] GetSumRange(Range a, Range b)
        {
            const int rangeCount = 2;

            Range[] array = new Range[rangeCount];

            if (a.To < b.From || a.From > b.To)
            {
                array[0] = a;
                array[1] = b;
            }
            else
            {
                array[0] = new Range();

                array[0].From = (a.From < b.From) ? a.From : b.From;
                array[0].To = (b.To > a.To) ? b.To : a.To;
                array[1] = null;
            }
            return array;
        }

        public static Range[] GetDifferenceRange(Range a, Range b)
        {
            const int rangeCount = 2;

            Range[] array = new Range[rangeCount];

            if (a.To < b.From || a.From > b.To)
            {
                array[0] = a;
                array[1] = null;
                return array;
            }
            else if (a.From < b.From && a.To > b.To)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = new Range();
                }

                array[0].From = a.From;
                array[0].To = b.From;
                array[1].From = b.To;
                array[1].To = a.To;
            }
            else
            {
                array[0] = new Range
                {
                    From = (a.From < b.From) ? a.From : b.To,
                    To = (a.To < b.To) ? b.From : a.To
                };
                array[1] = null;
            }
            return array;
        }
    }
}
