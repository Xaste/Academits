using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new MyList<int>();

            var node1 = new ListItem<int>(1, null, null);
            var node2 = new ListItem<int>(2, null, null);
            var node3 = new ListItem<int>(3, null, null);
            var node4 = new ListItem<int>(4, null, null);

            ListItem<int> nodeNull = null;

            var c = nodeNull?.Copy();
            //var k = nodeNull.Copy();


            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;

            node1.Random = node3;
            node2.Random = node4;
            node3.Random = node1;
            node4.Random = node4;


            Console.WriteLine();

            var list2 = new List<ListItem<int>>();
            list2.Add(node1);
            list2.Add(node2);
            list2.Add(node3);
            list2.Add(node4);

            foreach (var item in list2)
            {
                var copy = item.Copy();
                copy.Next = item.Next;
                item.Next = copy;
            }

            foreach (var item in list2)
            {
                item.Next.Random = item.Random.Next;
            }

            ListItem<int> copyList = node1.Next;

            foreach (var item in list2)
            {
                var currentCopy = item.Next;
                var originalNext = currentCopy.Next;

                var copyNext = (originalNext != null) ? originalNext : null;

                item.Next = originalNext;
                currentCopy.Next = copyNext;
            }



            Console.WriteLine();





        }
    }
}
