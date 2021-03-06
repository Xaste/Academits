﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageDoWhile
{
    class AverageDoWhile
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int second = Convert.ToInt32(Console.ReadLine());

            if (first < 2 || first > second)
            {
                Console.WriteLine("Введены неправильные данные");
            }
            else
            {
                int i = first;
                int sum = 0;
                int quantity = 0;

                do
                {
                    sum += i;
                    ++quantity;
                    ++i;
                }
                while (i <= second);
                double average = (double)sum / quantity;
                Console.WriteLine($"Среднее арифмитическое заданного диапозона: {average}");

                sum = 0;
                quantity = 0;
                i = first;

                do
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        ++quantity;
                    }
                    ++i;
                }
                while (i <= second);

                average = (double)sum / quantity;
                Console.WriteLine($"Среднее арифмитическое четных чисел заданного диапозона: {average}");
                Console.ReadLine();
            }
        }
    }
}
