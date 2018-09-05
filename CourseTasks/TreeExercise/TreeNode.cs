using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class TreenNode<T> where T : IComparable
    {
        public TreenNode<T> Left { get; set; }
        public TreenNode<T> Right { get; set; }

        public T value;

        public TreenNode(T data)
        {
            this.value = data;
            Left = null;
            Right = null;
        }
    }
}
