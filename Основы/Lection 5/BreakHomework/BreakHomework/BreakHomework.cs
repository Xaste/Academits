using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakHomework
{
    class BreakHomework
    {
        static void Main(string[] args)
        {
            string targerstring = "Угадал!";

            int countTry = 0;
            while (true)
            {
                ++countTry;
                Console.Write($"Попытка номер {countTry}. Введите строку: ");
                string inputString = Console.ReadLine();

                if (inputString == targerstring)
                {
                    Console.WriteLine($"Угадал! Всего попыток: {countTry}");
                    break;
                }
            }

            for (int i = 1; ; i++)
            {
                Console.Write($"Попытка номер {i}. Введите строку: ");
                string inputString = Console.ReadLine();

                if (inputString == targerstring)
                {
                    Console.WriteLine($"Угадал! Всего попыток: {i}");
                    break;
                }
            }
        }
    }
}
