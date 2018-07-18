﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Rectangle : IShape
    {
        public double HeightLength { get; set; }
        public double WidthLength { get; set; }

        public double GetArea()
        {
            return HeightLength * WidthLength;
        }

        public double GetHeight()
        {
            return HeightLength;
        }

        public double GetPerimeter()
        {
            return 2 * HeightLength + 2 * WidthLength;
        }

        public double GetWidth()
        {
            return WidthLength;
        }
    }
}
