using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координаты x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координаты x3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координаты y3:");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-10;

            bool isLayOnLine = Math.Abs((y3 - y1) * (x2 - x1) - (y2 - y1) * (x3 - x1)) <= epsilon;//Если третья точка лежит на прямой, образованной из предыдущих вдух точек, то они все три лежат на одной прямой. В такой проверке деление на ноль исключено

            if (isLayOnLine)
            {
                Console.WriteLine("Точки с данными координатами лежат на одной линии!");
            }
            else
            {
                double lengthLineA = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
                double lengthLineB = Math.Sqrt(Math.Pow(y3 - y2, 2) + Math.Pow(x3 - x2, 2));
                double lengthLineC = Math.Sqrt(Math.Pow(y3 - y1, 2) + Math.Pow(x3 - x1, 2));

                double perimeter = lengthLineA + lengthLineB + lengthLineC;

                double triangleArea = Math.Sqrt(perimeter / 2 * (perimeter / 2 - lengthLineA) * (perimeter / 2 - lengthLineC) * (perimeter / 2 - lengthLineB));

                Console.WriteLine($"Площадь треугольника равна {triangleArea}");
            }
            Console.ReadLine();
        }
    }
}
