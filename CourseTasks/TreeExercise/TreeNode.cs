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

        public T Value { get; set; }

        public TreeNode(T data)
        {
            Value = data;
            Left = null;
            Right = null;
        }

        internal List<TreeNode<T>> GetChildren()
        {
            var result = new List<TreeNode<T>>();

            if (!ReferenceEquals(Left, null))
            {
                result.Add(Left);
            }

            if (!ReferenceEquals(Right, null))
            {
                result.Add(Right);
            }

            return result;
        }
    }
}
