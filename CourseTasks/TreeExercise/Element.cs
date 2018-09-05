using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class TreeElement<T>
    {
        public TreeElement<T> Left { get; set; }
        public TreeElement<T> Right { get; set; }

        public T data;

        public TreeElement(T data)
        {
            this.data = data;
        }

        public TreeElement(T data, TreeElement<T> left, TreeElement<T> right)
        {
            this.data = data;
            Left = left;
            Right = right;
        }
    }
}
