using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Square : IShape
    {
        public double SideLength { get; set; }

        public Square(double a)
        {
            SideLength = a;
        }

        public double GetArea()
        {
            return Math.Pow(SideLength, 2);
        }

        public double GetHeight()
        {
            return SideLength;
        }

        public double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public double GetWidth()
        {
            return SideLength;
        }
    }
}
