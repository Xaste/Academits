using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Parameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string e in args)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
