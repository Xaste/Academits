using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchHomework
{
    class SwitchHomework
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый операнд: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второй операнд: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите команду: ");
            int command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    Console.WriteLine(operand1 + operand2);
                    break;
                case 2:
                    Console.WriteLine(operand1 - operand2);
                    break;
                case 3:
                    Console.WriteLine(operand1 * operand2);
                    break;
                case 4:
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Делить на ноль нельзя!");
                    }
                    else
                    {
                        Console.WriteLine((double)operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная операция!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
