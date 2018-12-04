using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            using (StreamReader reader = new StreamReader("input.txt"))
            {
                var line = reader.ReadLine();
                string[] splits = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                first = Convert.ToInt32(splits[0]);
                second = Convert.ToInt32(splits[1]);
            }

            /*Console.Write("Введите первое число: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число число: ");
            int second = Convert.ToInt32(Console.ReadLine());*/

            if (first < 2 || first > second)
            {
                Console.WriteLine("Введены неправильные данные");
            }
            else
            {
                int i = first;
                int sum = 0;
                int quantity = 0;

                while (i <= second)
                {
                    sum += i;
                    ++quantity;
                    ++i;
                }
                double average = (double)sum / quantity;
                Console.WriteLine($"Среднее арифмитическое заданного диапозона: {average}");

                sum = 0;
                quantity = 0;
                i = first;

                while (i <= second)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                        ++quantity;
                    }
                    ++i;
                }
                average = (double)sum / quantity;
                Console.WriteLine($"Среднее арифмитическое четных чисел заданного диапозона: {average}");
                Console.ReadLine();
            }
        }
    }
}