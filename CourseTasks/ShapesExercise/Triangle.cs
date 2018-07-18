using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Triangle : IShape
    {
        enum Coordinats
        {
            x = 0,
            y = 1
        }

        public double[] FirstSide { get; }
        public double[] SecondSide { get; }
        public double[] ThirdSide { get; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            FirstSide = new double[2] { x1, y1 };
            SecondSide = new double[2] { x2, y2 };
            ThirdSide = new double[2] { x3, y3 };
        }

        public double GetArea()
        {
            double lengthLineA = GetSidelength(FirstSide, SecondSide);
            double lengthLineB = GetSidelength(SecondSide, ThirdSide);
            double lengthLineC = GetSidelength(FirstSide, ThirdSide);

            double perimeter = GetPerimeter();

            return Math.Sqrt(perimeter / 2 * (perimeter / 2 - lengthLineA) * (perimeter / 2 - lengthLineC) * (perimeter / 2 - lengthLineB));
        }

        public double GetHeight()
        {
            double maxY = Math.Max(Math.Max(FirstSide[(int)Coordinats.y], SecondSide[(int)Coordinats.y]), ThirdSide[(int)Coordinats.y]);
            double minY = Math.Min(Math.Min(FirstSide[(int)Coordinats.y], SecondSide[(int)Coordinats.y]), ThirdSide[(int)Coordinats.y]);
            return maxY - minY;
        }

        public double GetPerimeter()
        {
            return GetSidelength(FirstSide, SecondSide) + GetSidelength(SecondSide, ThirdSide) + GetSidelength(FirstSide, ThirdSide);
        }

        public double GetWidth()
        {
            double maxX = Math.Max(Math.Max(FirstSide[(int)Coordinats.x], SecondSide[(int)Coordinats.x]), ThirdSide[(int)Coordinats.x]);
            double minX = Math.Min(Math.Min(FirstSide[(int)Coordinats.x], SecondSide[(int)Coordinats.x]), ThirdSide[(int)Coordinats.x]);
            return maxX - minX;
        }

        private double GetSidelength(double[] a, double[] b)
        {
            return Math.Sqrt(Math.Pow(b[(int)Coordinats.y] - a[(int)Coordinats.y], 2) + Math.Pow(b[(int)Coordinats.x] - a[(int)Coordinats.x], 2));
        }
    }
}
