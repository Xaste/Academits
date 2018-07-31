using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListExercise
{
    class ListExercise
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>(new int[] { 1, 2, 3, 4, 5 });

            var length = list.GetListLength();
            Console.WriteLine(length);

            var firstElement = list.GetFirstElement();
            Console.WriteLine(firstElement);
        }
    }
}
