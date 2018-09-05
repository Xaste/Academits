using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class TreenNode<T>
    {
        public TreenNode<T> Left { get; set; }
        public TreenNode<T> Right { get; set; }

        public T value;

        public TreenNode(T data)
        {
            this.value = data;
        }

        public TreenNode(T data, TreenNode<T> left, TreenNode<T> right)
        {
            this.value = data;
            Left = left;
            Right = right;
        }
    }
}
