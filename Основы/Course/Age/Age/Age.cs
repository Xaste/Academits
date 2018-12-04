using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Ввдеите свой возраст от 1 до 112 включительно: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Возраст не может быть отрицательным числом");
            }
            else
            {
                if (age < 1)
                {
                    Console.WriteLine("Вы слишком малы");
                }
                else if (age > 112)
                {
                    Console.WriteLine("Вы слишком стары");
                }
                else
                {
                    string ageEnd;
                    if (age / 10 % 10 == 1 || age % 10 == 0 || age % 10 > 4)
                    {
                        ageEnd = "лет";
                    }
                    else if (age % 10 > 1)
                    {
                        ageEnd = "года";
                    }
                    else
                    {
                        ageEnd = "год";
                    }
                    Console.WriteLine($"Вам {age} {ageEnd}");
                }
            }

        }
    }
}
