using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInString
{
    class NumbersInString
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите последнее число: ");
            int last = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество чисел в строке: ");
            int countInStringFinal = Convert.ToInt32(Console.ReadLine());

            int i = first;
            int countInStringCurrent = 0;

            while (i <= last)
            {
                if (countInStringCurrent == countInStringFinal)
                {
                    Console.WriteLine();
                    countInStringCurrent = 0;
                }
                Console.Write(i.ToString().PadLeft(4));
                ++countInStringCurrent;
                ++i;
            }
            Console.ReadLine();
        }
    }
}

