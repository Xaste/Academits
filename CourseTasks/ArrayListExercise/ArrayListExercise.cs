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

            var list3 = new MyList<int>(13) { 55, 112 };

            foreach (var item in list3)
            {
                Console.WriteLine(item);
                //list3.Add(55);
            }

            var list4 = new MyList<int>(new int[] { });
            list4.Add(5);
            list4.Remove(5);
            list4.Add(1);
            list4.Add(2);
            list4.Add(3);
            list4.RemoveAt(0);
            //var no = list4[2];
            list4.Add(4);
            list4.Insert(2, 55);
            //list4.Remove(55);

            var contains55 = list4.Contains(66);
            var index = list4.IndexOf(99);

            var array = new int[10];
            list4.CopyTo(array, 6);

            list2.Clear();
            list2.EnsureCapacity(55);
            list2.EnsureCapacity(11);
            list2.Add(1);
            list2.TrimToSize();
            list2.Clear();
            list2.TrimToSize();

            var listString = new MyList<string>(new string[] { "123", "234" });
            listString.Add("sasda");
            var contains = listString.Contains("123");
            listString.TrimToSize();
            listString.Clear();
            listString.TrimToSize();
            listString.Add("55");
            contains = listString.Contains(null);
            listString.Add(null);
            contains = listString.Contains(null);
        }
    }
}
