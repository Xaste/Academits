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

        public Circle(double r)
        {
            Radius = r;
        }

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Тип фигуры: {GetType()}");
            sb.AppendLine($"Радиус: {Radius}");
            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return Convert.ToString(sb);
        }

        /*public override bool Equals(object obj)
        {
            if (obj is Circle && obj != null)
            {
                Circle circle;
                circle = (Circle)obj;
                if (circle.Radius == this.Radius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }*/

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }
    }
}
