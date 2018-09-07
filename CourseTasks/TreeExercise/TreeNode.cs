using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class TreeNode<T> where T : IComparable
    {
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public T value;

        public TreeNode(T data)
        {
            this.value = data;
            Left = null;
            Right = null;
        }
    }
}
