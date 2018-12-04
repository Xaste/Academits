using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerRiseExercise
{
    class PowerRiseExercise
    {
        static void Main(string[] args)
        {
            int number = 3;
            int power = 0;
            Console.WriteLine(RisePowerRecursive(number, power));
            Console.WriteLine(RisePower(number, power));
        }

        public static int RisePowerRecursive(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            return RisePowerRecursive(number, power - 1) * number;
        }

        public static int RisePower(int number, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
