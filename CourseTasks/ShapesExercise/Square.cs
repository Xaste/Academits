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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Тип фигуры: {GetType()}");
            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return Convert.ToString(sb);
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            int prime = 17;
            int hash = 1;
            hash = prime * hash + (int)SideLength;
            hash = prime * hash + (int)GetArea();
            hash = prime * hash + (int)GetPerimeter();

            return hash;
        }
    }
}
