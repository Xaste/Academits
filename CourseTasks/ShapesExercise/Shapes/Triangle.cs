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

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            FirstPoint = new Point(x1, y1);
            SecondPoint = new Point(x2, y2);
            ThirdPoint = new Point(x3, y3);
        }

        public double GetArea()
        {
            double lengthLineA = GetSideLength(FirstPoint, SecondPoint);
            double lengthLineB = GetSideLength(SecondPoint, ThirdPoint);
            double lengthLineC = GetSideLength(FirstPoint, ThirdPoint);

            double halfPerimeter = GetPerimeter();

            return Math.Sqrt(halfPerimeter * (halfPerimeter - lengthLineA) * (halfPerimeter - lengthLineC) * (halfPerimeter - lengthLineB));
        }

        public double GetHeight()
        {
            double maxY = Math.Max(Math.Max(FirstPoint.Y, SecondPoint.Y), ThirdPoint.Y);
            double minY = Math.Min(Math.Min(FirstPoint.Y, SecondPoint.Y), ThirdPoint.Y);

            return maxY - minY;
        }

        public double GetPerimeter()
        {
            return GetSideLength(FirstPoint, SecondPoint) + GetSideLength(SecondPoint, ThirdPoint) + GetSideLength(FirstPoint, ThirdPoint);
        }

        public double GetWidth()
        {
            double maxX = Math.Max(Math.Max(FirstPoint.X, SecondPoint.X), ThirdPoint.X);
            double minX = Math.Min(Math.Min(FirstPoint.X, SecondPoint.X), ThirdPoint.X);

            return maxX - minX;
        }

        private static double GetSideLength(Point a, Point b)
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

            sb.AppendLine($"Длина первой стороны: {GetSideLength(FirstPoint, SecondPoint)}");
            sb.AppendLine($"Длина второй стороны: {GetSideLength(SecondPoint, ThirdPoint)}");
            sb.AppendLine($"Длина третьей стороны: {GetSideLength(FirstPoint, ThirdPoint)}");

            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is null || obj.GetType() != this.GetType())
            {
                return false;
            }

            Triangle triangle = (Triangle)obj;

            bool isFirstCondition = FirstPoint == triangle.FirstPoint && SecondPoint == triangle.SecondPoint && ThirdPoint == triangle.ThirdPoint;
            bool isSecondCondition = FirstPoint == triangle.SecondPoint && SecondPoint == triangle.ThirdPoint && ThirdPoint == triangle.FirstPoint;
            bool isThirdCondition = FirstPoint == triangle.ThirdPoint && SecondPoint == triangle.FirstPoint && ThirdPoint == triangle.SecondPoint;

            return (isFirstCondition || isSecondCondition || isThirdCondition);
        }

        public override int GetHashCode()
        {
            return FirstPoint.GetHashCode() + SecondPoint.GetHashCode() + ThirdPoint.GetHashCode();
        }
    }
}
