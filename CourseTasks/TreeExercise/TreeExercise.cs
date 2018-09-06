using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class TreeExercise
    {
        static void Main(string[] args)
        {
            var tree0 = new Tree<string>(null);

            tree0.Add("C");
            tree0.Add("A");
            tree0.Add("Z");
            tree0.Add("B");

            var tree = new Tree<int>(10);
            tree.Add(5);
            tree.Add(4);
            tree.Add(4);
            tree.Add(3);
            tree.Add(6);

            var tree2 = new Tree<int>(new int[] { 10, 5, 4, 7, 22 });

            var findNode = tree2.GetPreviousNode(4);
            var findNode2 = tree.FindNode(5);
            var findNode3 = tree.FindNode(4);

            var res = tree2.GoThroughWide().ToList();
            foreach (var item in res)
            {
                item.value++;
            }

            var res2 = tree.GoThroughWide();
            Console.WriteLine(tree2.GetCount());

            tree.Add(2);
            tree.Add(7);

            tree.RemoveNode(3);
            tree.RemoveNode(6);

            var tree3 = new Tree<int>(10, 5, 20, 15, 25, 23, 22);

            tree3.RemoveNode(20);
        }
    }
}
