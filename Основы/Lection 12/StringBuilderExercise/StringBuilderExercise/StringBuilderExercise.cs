using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExercise
{
    class StringBuilderExercise
    {
        static void Main(string[] args)
        {
            int begin = 1;
            int last = 100;

            StringBuilder sb = new StringBuilder();
            for (int i = begin; i < last; i++)
            {
                sb.Append(i);
                sb.Append(", ");
            }
            sb.Append($"{last}.");

            string answer = sb.ToString();
            Console.WriteLine(answer);
        }
    }
}
