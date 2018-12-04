using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDate
{
    class NextDate
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день: ");
            int dayInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц: ");
            int monthInput = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите год: ");
            int yearInput = Convert.ToInt32(Console.ReadLine());

            bool isLeapYear = (yearInput % 400 == 0 || yearInput % 100 != 0) && yearInput % 4 == 0;
            bool isMonth31 = monthInput != 2 && (monthInput < 8 && monthInput % 2 == 1) || (monthInput >= 8 && monthInput % 2 == 0);

            int dayEnd;
            if (monthInput == 2)
            {
                dayEnd = isLeapYear ? 29 : 28;
            }
            else
            {
                dayEnd = isMonth31 ? 31 : 30;
            }

            if (yearInput <= 0 || monthInput <= 0 || monthInput > 12 || dayInput <= 0 || dayInput > dayEnd)
            {
                Console.WriteLine("Введена некорректная дата!");
            }
            else
            {
                int dayAnswer;
                int monthAnswer;
                int yearAnswer;
                if (monthInput == 12 && dayInput == dayEnd)
                {
                    yearAnswer = yearInput + 1;
                    monthAnswer = 1;
                    dayAnswer = 1;
                }
                else
                {
                    yearAnswer = yearInput;
                    monthAnswer = (dayInput == dayEnd) ? (monthInput + 1) : monthInput;
                    dayAnswer = dayInput < dayEnd ? dayInput + 1 : 1;
                }
                Console.WriteLine($"{dayAnswer:d2}.{monthAnswer:d2}.{yearAnswer}");
            }
            Console.ReadLine();
        }

    }
}
