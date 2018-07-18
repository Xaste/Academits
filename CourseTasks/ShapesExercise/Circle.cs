using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetHeight()
        {
            return Radius * 2;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double GetWidth()
        {
            return Radius * 2;
        }
    }
}
