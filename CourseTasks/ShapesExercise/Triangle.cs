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
            throw new NotImplementedException();
        }

        public double GetHeight()
        {
            double maxY = Math.Max(Math.Max(FirstSide[(int)Coordinats.y], SecondSide[(int)Coordinats.y]), ThirdSide[(int)Coordinats.y]);
            double minY = Math.Min(Math.Min(FirstSide[(int)Coordinats.y], SecondSide[(int)Coordinats.y]), ThirdSide[(int)Coordinats.y]);
            return maxY - minY;
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetWidth()
        {
            double maxX = Math.Max(Math.Max(FirstSide[(int)Coordinats.x], SecondSide[(int)Coordinats.x]), ThirdSide[(int)Coordinats.x]);
            double minX = Math.Min(Math.Min(FirstSide[(int)Coordinats.x], SecondSide[(int)Coordinats.x]), ThirdSide[(int)Coordinats.x]);
            return maxX - minX;
        }
    }
}
