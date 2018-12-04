using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload
{
    class Overload
    {
        static void Main(string[] args)
        {
            byte a = 1;
            short b = 2;
            int c = 3;
            long d = 4;
            float e = 5.1f;
            double f = 6.1;

            Console.WriteLine(GetTypeSize(a));
            Console.WriteLine(GetTypeSize(b));
            Console.WriteLine(GetTypeSize(c));
            Console.WriteLine(GetTypeSize(d));
            Console.WriteLine(GetTypeSize(e));
            Console.WriteLine(GetTypeSize(f));
        }

        public static int GetTypeSize(byte a)
        {
            return 1;
        }

        public static int GetTypeSize(short a)
        {
            return 2;
        }

        public static int GetTypeSize(int a)
        {
            return 4;
        }

        public static int GetTypeSize(long a)
        {
            return 8;
        }

        public static int GetTypeSize(float a)
        {
            return 4;
        }

        public static int GetTypeSize(double a)
        {
            return 8;
        }
    }
}
