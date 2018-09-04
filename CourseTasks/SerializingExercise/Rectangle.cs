using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializingExercise
{
    [Serializable]
    class Rectangle
    {
        private double height;
        private double width;

        [NonSerialized]
        private double area;

        public Rectangle (double height, double width)
        {
            this.height = height;
            this.width = width;

            area = width * height;
        }

        [OnDeserialized]
        private void GetArea(StreamingContext context)
        {
            area = height * width;
        }
    }
}
