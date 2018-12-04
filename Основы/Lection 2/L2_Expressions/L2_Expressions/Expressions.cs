using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Expressions
{
    class Expressions
    {
        static void Main(string[] args)
        {
            double x = 3 - (56 - 12) / 44 * (4 / 2);
            double y = 2 * x / (33 - x);
            double z = -x / (2 * y);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            Console.ReadLine();
        }
    }
}
