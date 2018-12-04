using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From0to100WithExceptions
{
    class From0to100WithExceptions
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if ((i == 5 || i % 3 == 0 || (i >= 60 && i <= 80)))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int j = 0;
            while (j <= 100)
            {
                if ((j == 5 || j % 3 == 0 || (j >= 60 && j <= 80)))
                {
                    ++j;
                    continue;
                }
                Console.WriteLine(j);
                ++j;
            }
        }
    }
}
