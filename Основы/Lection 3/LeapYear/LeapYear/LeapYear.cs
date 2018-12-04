using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year <= 0)//В юлианском и григорианском календарях нет нулевого года.
            {
                Console.WriteLine("Введен неверный год!");
            }
            else
            {
                if ((year % 400 == 0 || year % 100 != 0) && year % 4 == 0)
                {
                    Console.WriteLine("Введенный год является високосным");
                }
                else
                {
                    Console.WriteLine("Введенный год не является високосным");
                }

                Console.ReadLine();
            }
        }
    }
}
