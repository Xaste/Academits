using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Введите второе целое число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine("Введенные числа равны");
            }
            else if (number1 > number2)
            {
                Console.WriteLine($"Наибольшее число {number1}");
                Console.WriteLine($"Наименьшее число {number2}");
            }
            else
            {
                Console.WriteLine($"Наибольшее число {number2}");
                Console.WriteLine($"Наименьшее число {number1}");
            }

            int max = (number1 > number2) ? number1 : number2;
            int min = (number1 > number2) ? number2 : number1;
            if (max == min)
            {
                Console.WriteLine("Введенные числа равны");
            }
            else
            {
                Console.WriteLine($"Наибольшее число {max}; Наименьшее число {min}");
            }

            Console.ReadLine();
        }
    }
}
