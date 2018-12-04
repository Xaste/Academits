using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchExercise
{
    class SwitchExercise
    {
        static void Main(string[] args)
        {
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "print":
                    Console.Write("Введите строку: ");
                    string inputString = Console.ReadLine();
                    Console.WriteLine(inputString);
                    break;
                case "sum":
                    Console.Write("Введите первое число: ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double sum = a + b;
                    Console.WriteLine($"Сумма этих чисел равна {sum}");
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
            Console.ReadLine();
        }
    }
}
