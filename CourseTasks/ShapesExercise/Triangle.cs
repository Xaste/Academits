using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesExercise
{
    class Triangle : IShape
    {
        enum Coordinats
        {
            x = 0,
            y = 1
        }

        public double[] FirstPoint { get; }
        public double[] SecondPoint { get; }
        public double[] ThirdPoint { get; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            FirstPoint = new double[2] { x1, y1 };
            SecondPoint = new double[2] { x2, y2 };
            ThirdPoint = new double[2] { x3, y3 };
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
            double maxY = Math.Max(Math.Max(FirstPoint[(int)Coordinats.y], SecondPoint[(int)Coordinats.y]), ThirdPoint[(int)Coordinats.y]);
            double minY = Math.Min(Math.Min(FirstPoint[(int)Coordinats.y], SecondPoint[(int)Coordinats.y]), ThirdPoint[(int)Coordinats.y]);
            return maxY - minY;
        }

        public double GetPerimeter()
        {
            return GetSidelength(FirstPoint, SecondPoint) + GetSidelength(SecondPoint, ThirdPoint) + GetSidelength(FirstPoint, ThirdPoint);
        }

        public double GetWidth()
        {
            double maxX = Math.Max(Math.Max(FirstPoint[(int)Coordinats.x], SecondPoint[(int)Coordinats.x]), ThirdPoint[(int)Coordinats.x]);
            double minX = Math.Min(Math.Min(FirstPoint[(int)Coordinats.x], SecondPoint[(int)Coordinats.x]), ThirdPoint[(int)Coordinats.x]);
            return maxX - minX;
        }

        private double GetSidelength(double[] a, double[] b)
        {
            return Math.Sqrt(Math.Pow(b[(int)Coordinats.y] - a[(int)Coordinats.y], 2) + Math.Pow(b[(int)Coordinats.x] - a[(int)Coordinats.x], 2));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Тип фигуры: {GetType()}");

            sb.AppendLine($"Координаты первой точки: {FirstPoint[(int)Coordinats.x]}, {FirstPoint[(int)Coordinats.y]}");
            sb.AppendLine($"Координаты второй точки: {SecondPoint[(int)Coordinats.x]}, {SecondPoint[(int)Coordinats.y]}");
            sb.AppendLine($"Координаты третей точки: {ThirdPoint[(int)Coordinats.x]}, {ThirdPoint[(int)Coordinats.y]}");

            sb.AppendLine($"Длина первой стороны: {GetSidelength(FirstPoint, SecondPoint)}");
            sb.AppendLine($"Длина второй стороны: {GetSidelength(SecondPoint, ThirdPoint)}");
            sb.AppendLine($"Длина третьей стороны: {GetSidelength(FirstPoint, ThirdPoint)}");

            sb.AppendLine($"Высота: {GetHeight()}");
            sb.AppendLine($"Ширина: {GetWidth()}");
            sb.AppendLine($"Площадь: {GetArea()}");
            sb.AppendLine($"Периметр: {GetPerimeter()}");

            return Convert.ToString(sb);
        }
    }
}
