using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNumber
{
    class PositiveNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Данное число - положительное");
            }

            if (/*number != 0 &&*/ number % 2 == 0)
            {
                Console.WriteLine("Данное число - четное");
            }

            if (/*number != 0 && */number % 5 == 0)
            {
                Console.WriteLine($"Данное число кратно 5");
            }

            Console.ReadLine();
        }
    }
}
