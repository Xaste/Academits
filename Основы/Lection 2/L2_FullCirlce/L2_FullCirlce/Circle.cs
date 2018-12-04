using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_FullCirlce
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = 7;
            double calculatedAreaOfCircle = Math.PI * Math.Pow(radius, 2);
            double calculatedLengthOfCircle = 2 * Math.PI * radius;
            Console.WriteLine($"Радиус равен {radius}.");
            Console.WriteLine($"Площадь круга равна {calculatedAreaOfCircle}.");
            Console.WriteLine($"Длина окружности равна {calculatedLengthOfCircle}.");
            Console.WriteLine();

            double areaOfCircle = 236;
            double calculatedRadius = Math.Sqrt(areaOfCircle / Math.PI);
            Console.WriteLine($"Площадь круга равна {areaOfCircle}.");
            Console.WriteLine($"Радиус равен {calculatedRadius}.");
            Console.WriteLine();

            double bonusRadius = 5;
            double angle = 30;
            double calculatedAreaOfSector = Math.PI * Math.Pow(bonusRadius, 2) * angle / 360;
            Console.WriteLine($"Радиус равен {bonusRadius}, угол равен {angle} градусов.");
            Console.WriteLine($"Площадь сектора равна {calculatedAreaOfSector}.");

            Console.ReadLine();
        }
    }
}
