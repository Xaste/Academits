using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Arithmetic
{
    class Arithmetic
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 7;

            double c = 3.5;
            double d = 2.9;

            Console.WriteLine("Пример целочисленного сложения(+): " + a + " + " + b + " = " + (a+b) );
            Console.WriteLine("Пример целочисленного вычитания(-): " + a + " - " + b + " = " + (a - b));
            Console.WriteLine("Пример целочисленного умножения(*): " + a + " * " + b + " = " + (a * b));
            Console.WriteLine("Пример целочисленного деления(/): " + a + " / " + b + " = " + (double)a / b);
            Console.WriteLine("Пример получения остатка от целочисленного деления(%): " + a + " % " + b + " = " + (a % b));

            Console.Write(Environment.NewLine);

            Console.WriteLine("Пример вещественного сложения(+): " + c + " + " + d + " = " + (c + d));
            Console.WriteLine("Пример вещественного вычитания(-): " + c + " - " + d + " = " + (c - d));
            Console.WriteLine("Пример вещественного умножения(*): " + c + " * " + d + " = " + (c * d));
            Console.WriteLine("Пример вещественного деления(/): " + c + " / " + d + " = " + (c / d));

            Console.ReadLine();
        }
    }
}
