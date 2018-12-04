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
            Console.Write("Введите размер таблицы: ");
            int tableSize = Convert.ToInt32(Console.ReadLine());

            int[,] table = GetMultiplicationTable(tableSize);

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j].ToString().PadLeft(5, ' ')}");
                }
                Console.WriteLine();
            }
        }

        public static int[,] GetMultiplicationTable(int tableSize)
        {
            int[,] table = new int[tableSize, tableSize];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }
            return table;
        }
    }
}
