using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double coefficientA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент b: ");
            double coefficientB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент c: ");
            double coefficientC = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-100;

            if (Math.Abs(coefficientA) < epsilon && Math.Abs(coefficientB) < epsilon)
            {
                if (Math.Abs(coefficientC) < epsilon)
                {
                    Console.WriteLine("x является любым числом");
                }
                else
                {
                    Console.WriteLine("Решений нет");
                }
            }
            else
            {
                if (Math.Abs(coefficientA) < epsilon)
                {
                    double answer = -coefficientC / coefficientB;
                    Console.WriteLine($"Простое уравнение, х = {answer}");
                }
                else
                {
                    double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;

                    if (Math.Abs(discriminant) < epsilon)
                    {
                        double answer = -coefficientB / (2 * coefficientA);
                        Console.WriteLine($"1 корень, x = {answer}");
                    }
                    else if (discriminant < 0)
                    {
                        Console.WriteLine($"Дискриминант {discriminant} < 0. Корней нет.");
                    }
                    else
                    {
                        double answer1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                        double answer2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
                        Console.WriteLine($"Два корня: x1 = {answer1}, x2 = {answer2}");
                    }
                }
            }
        }
    }
}
