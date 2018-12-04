using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakExample
{
    class BreakExample
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i >= 30)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
