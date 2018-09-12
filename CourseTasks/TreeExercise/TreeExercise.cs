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
            var tree = new Tree<int>(10);
            tree.Add(5);
            tree.Add(4);
            tree.Add(4);
            tree.Add(3);
            tree.Add(6);

            var tree2 = new Tree<int>(10, 5, 20, 15, 25, 23, 27, 26, 30, 24);

            var findNode2 = tree.FindNode(5);
            var findNode3 = tree.FindNode(4);

            tree2.Add(55);
            tree2.GoThroughWide(x => Console.WriteLine(x.Value));

            Console.WriteLine();

            //var count = tree2.GetCount();

            tree.Add(2);
            tree.Add(7);

            tree.RemoveNode(3);
            tree.RemoveNode(6);

            var tree3 = new Tree<int>(10, 5, 20, 15, 25, 23, 27, 26, 30, 24);

            tree3.GoThroughDeepRecursion(x => Console.WriteLine(x.Value));

            Console.WriteLine();

            tree3.GoThroughDeep(x => Console.WriteLine(x.Value));

            var stringTree = new Tree<string>("ddd", "bbb", "fff", null);
            stringTree.Add(null);

            var nullString = stringTree.FindNode(null);
        }
    }
}
