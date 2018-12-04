using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введитие ширину прямоугольника: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double area = length * width;
            double perimeter = 2 * length + 2 * width;

            Console.WriteLine($"Area of rectangle = {area}");
            Console.WriteLine($"Perimeter of rectangle = {perimeter}");

            Console.WriteLine("Длина прямоугольника = {0}, ширина = {1}, площадь прямоугольника = {2}, периметр = {3}", length, width, area, perimeter);

            Console.ReadLine();
        }
    }
}
