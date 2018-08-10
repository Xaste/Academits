using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExercise
{
    class ArrayListExercise
    {
        static void Main(string[] args)
        {
            var list1 = new MyList<int>();
            var list2 = new MyList<int>(new int[] { 1, 22, 55, 4, -3 });

            Console.WriteLine(list2[4]);
            list1.Add(55);
            Console.WriteLine(list1[0]);
            list1[0] = 5;
            Console.WriteLine(list1[0]);

            for (var i = 0; i < 100; i++)
            {
                list1.Add(i);
            }

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
