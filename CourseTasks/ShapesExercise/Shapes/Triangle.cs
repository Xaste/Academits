using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Triangle : IShape
    {
        public Point FirstPoint { get; set; }
        public Point SecondPoint { get; set; }
        public Point ThirdPoint { get; set; }

        public Point First { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            FirstPoint = new Point(x1, y1);
            SecondPoint = new Point(x2, y2);
            ThirdPoint = new Point(x3, y3);
        }

        public double GetArea()
        {
            double lengthLineA = GetSidelength(FirstPoint, SecondPoint);
            double lengthLineB = GetSidelength(SecondPoint, ThirdPoint);
            double lengthLineC = GetSidelength(FirstPoint, ThirdPoint);

            double perimeter = GetPerimeter();

            return Math.Sqrt(perimeter / 2 * (perimeter / 2 - lengthLineA) * (perimeter / 2 - lengthLineC) * (perimeter / 2 - lengthLineB));
        }

        public double GetHeight()
        {
            double maxY = Math.Max(Math.Max(FirstPoint.Y, SecondPoint.Y), ThirdPoint.Y);
            double minY = Math.Min(Math.Min(FirstPoint.Y, SecondPoint.Y), ThirdPoint.Y);

            return maxY - minY;
        }

        public double GetPerimeter()
        {
            return GetSidelength(FirstPoint, SecondPoint) + GetSidelength(SecondPoint, ThirdPoint) + GetSidelength(FirstPoint, ThirdPoint);
        }

        public double GetWidth()
        {
            double maxX = Math.Max(Math.Max(FirstPoint.X, SecondPoint.X), ThirdPoint.X);
            double minX = Math.Min(Math.Min(FirstPoint.X, SecondPoint.X), ThirdPoint.X);

            return maxX - minX;
        }

        private double GetSidelength(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.X - a.X, 2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Тип фигуры: {GetType()}");

            sb.AppendLine($"Координаты первой точки: ({FirstPoint.X}, {FirstPoint.Y})");
            sb.AppendLine($"Координаты второй точки: ({SecondPoint.X}, {SecondPoint.Y})");
            sb.AppendLine($"Координаты третей точки: ({ThirdPoint.X}, {ThirdPoint.Y})");

            sb.AppendLine($"Длина первой стороны: {GetSidelength(FirstPoint, SecondPoint)}");
            sb.AppendLine($"Длина второй стороны: {GetSidelength(SecondPoint, ThirdPoint)}");
            sb.AppendLine($"Длина третьей стороны: {GetSidelength(FirstPoint, ThirdPoint)}");

            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return FirstPoint.GetHashCode() + SecondPoint.GetHashCode() + ThirdPoint.GetHashCode();
        }
    }
}
