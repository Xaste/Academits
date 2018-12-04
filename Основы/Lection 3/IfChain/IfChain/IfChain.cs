using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChain
{
    class IfChain
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Введенное число {number} положительное");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Введенное число {number} отрицательно");
            }
            else
            {
                Console.WriteLine("Введенное число равно 0");
            }
            Console.ReadLine();
        }
    }
}
