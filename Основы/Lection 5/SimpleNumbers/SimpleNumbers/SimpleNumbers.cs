using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNumbers
{
    class SimpleNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= number; i++)
            {
                bool isSimpleNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimpleNumber = false;
                        break;
                    }
                }
                if (isSimpleNumber)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
