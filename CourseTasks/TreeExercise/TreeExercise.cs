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

            var findNode = tree2.FindNode(5);
        }
    }
}
