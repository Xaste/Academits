﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class ShapesPerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape x, IShape y)
        {
            if (x.GetPerimeter() > y.GetPerimeter())
            {
                return 1;
            }
            else if (x.GetPerimeter() < y.GetPerimeter())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}