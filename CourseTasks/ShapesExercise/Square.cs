using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Square : Rectangle
    {
        public Square(double a)
        {
            this.HeightLength = a;
            this.WidthLength = a;
        }
    }
}
