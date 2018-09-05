using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Tree<T> where T : IComparable
    {
        private TreenNode<T> head;

        public Tree(T root)
        {
            head = new TreenNode<T>(root);
        }

        /*public Tree(T[] data)
        {

        }*/

        public void Add(T data)
        {
            if (ReferenceEquals(data, null))
            {
                throw new NullReferenceException("Попытка добавить null в бинарное дерево поиска");
            }

            if (ReferenceEquals(head.value, null))
            {
                head.value = data;
                return;
            }

            var p = head;

            while (true) //(!ReferenceEquals(p, null))
            {
                if (p.value.CompareTo(data) > 0)
                {
                    if (ReferenceEquals(p.Left, null))
                    {
                        p.Left = new TreenNode<T>(data);
                        break;
                    }
                    p = p.Left;
                }
                else
                {
                    if (ReferenceEquals(p.Right, null))
                    {
                        p.Right = new TreenNode<T>(data);
                        break;
                    }
                    p = p.Right;
                }
            }
        }
    }
}
