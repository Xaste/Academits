using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposit
{
    class Deposit
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму депозита: ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ставку в %: ");
            double interest = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите продолжительность вклада (в месяцах): ");
            int durationMonths = Convert.ToInt32(Console.ReadLine());

            const int monthsInYear = 12;
            const int percentToDecimalDivider = 100;

            double sum = deposit;
            for (int i = 0; i < durationMonths; i++)
            {
                Console.Write($"Баланс: {sum:f2}  Месяц: {i + 1}  Начислено {sum * (interest / (monthsInYear * percentToDecimalDivider)):f2}  ");
                sum += sum * (interest / (percentToDecimalDivider * monthsInYear));
                Console.WriteLine($"Баланс: {sum:f2}");
            }

            double answerFormula = deposit * Math.Pow(1 + interest / (monthsInYear * percentToDecimalDivider), durationMonths);
            double epsilon = 1.0e-10;
            if (Math.Abs(answerFormula - sum) < epsilon)
            {
                Console.WriteLine("Решение с циклом совпадает с форумлой");
            }
            else
            {
                Console.WriteLine("Решение с циклом не совпадает с форумлой");
            }
            Console.WriteLine($"Прибыль: {sum - deposit:f2}.");
        }
    }
}
