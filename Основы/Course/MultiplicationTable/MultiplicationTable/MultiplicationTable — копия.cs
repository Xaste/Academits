using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("Ввежите размер таблицы умножения: ");
            int length = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j <= length; j++)
                    {
                        Console.Write(j.ToString().PadLeft(5, ' '));
                        if (j == 0)
                        {
                            Console.Write("|");
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    for (int j = 0; j <= length; j++)
                    {
                        Console.Write("-".PadLeft(5, '-'));
                        if (j == 0)
                        {
                            Console.Write("|");
                        }
                    }
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < length + 1; j++)
                {
                    int result;
                    if (j == 0)
                    {
                        result = i;
                    }
                    else
                    {
                        result = i * j;
                    }
                    Console.Write(result.ToString().PadLeft(5, ' '));
                    if (j == 0)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine();

                if (i == 0)
                {
                    for (int j = 0; j < length + 1; j++)
                    {
                        if (j == 1)
                        {
                            Console.Write("|");
                        }
                        Console.Write("-".PadLeft(5, '-'));
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
