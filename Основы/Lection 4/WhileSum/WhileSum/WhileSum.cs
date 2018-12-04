using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSum
{
    class WhileSum
    {
        static void Main(string[] args)
        {
            int first = 0;
            int last = 9;
            int i = first;
            int sum1 = 0;

            while (i <= last)
            {
                sum1 += i;
                ++i;
            }
            Console.WriteLine($"Сумма чисел от {first} до {last}: {sum1}");

            first = 3;
            last = 21;
            i = first;
            int sum2 = 0;

            while (i <= last)
            {
                sum2 += i;
                ++i;
            }
            Console.WriteLine($"Сумма чисел от {first} до {last}: {sum2}");

            i = first;
            int sum3 = 0;
            int evenNumber = 0;

            while (i <= last)
            {
                if (i % 2 == 0)
                {
                    sum3 += i;
                    ++evenNumber;
                }
                ++i;
            }
            Console.WriteLine($"Сумма четных чисел от {first} до {last}: {sum3}. Всего четных чисел:{evenNumber}");

            if (first % 2 == 1)
            {
                ++first;
            }

            i = first;
            sum3 = 0;
            evenNumber = 0;

            while (i <= last)
            {
                sum3 += i;
                ++evenNumber;
                i += 2;
            }
            Console.WriteLine($"Сумма четных чисел от {first} до {last}: {sum3}. Всего четных чисел:{evenNumber}");

            Console.ReadLine();
        }
    }
}
