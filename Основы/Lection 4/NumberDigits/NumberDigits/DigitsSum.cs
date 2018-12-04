using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsSum
{
    class DigitsSum
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            int sum = 0;
            do
            {
                sum += ((numberInput / i)) % 10;
                i *= 10;
            }
            while (numberInput / i != 0);
            Console.WriteLine($"Сумма цифр числа: {sum}");

            i = 1;
            sum = 0;
            do
            {
                int digit = ((numberInput / i)) % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                i *= 10;
            }
            while (numberInput / i != 0);
            Console.WriteLine($"Сумма нечетных цифр числа: {sum}");

            i = 1;
            sum = 0;
            int max = 0;
            do
            {
                int digit = ((numberInput / i)) % 10;
                if (digit > max)
                {
                    max = digit;
                }
                i *= 10;
            }
            while (numberInput / i != 0);
            Console.WriteLine($"Максимальная цифра в числе: {max}");

            Console.ReadLine();
        }
    }
}
