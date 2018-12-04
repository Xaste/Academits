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

            Console.Write(" ".PadLeft(5, ' '));
            Console.Write("|");
            for (int i = 1; i <= length; i++)
            {
                Console.Write(i.ToString().PadLeft(5, ' '));
            }
            Console.WriteLine();

            Console.Write("-");
            for (int i = 0; i <= length; i++)
            {
                Console.Write("-".PadLeft(5, '-'));
            }

            Console.WriteLine();
            for (int i = 1; i <= length; i++)
            {
                Console.Write(i.ToString().PadLeft(5, ' '));
                Console.Write("|");
                for (int j = 1; j < length + 1; j++)
                {
                    int result = i * j;
                    Console.Write(result.ToString().PadLeft(5, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
