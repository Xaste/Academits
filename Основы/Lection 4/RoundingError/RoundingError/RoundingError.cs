using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingError
{
    class RoundingError
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1.0e-10;
            if (Math.Abs(a - b) < epsilon)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Числа не равны");
            }
            Console.ReadLine();
        }
    }
}
