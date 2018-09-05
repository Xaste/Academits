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

        /*public Tree(T root)
        {
            head = new TreenNode<T>(root);
        }*/

        public Tree(params T[] data)
        {
            if (Equals(data, null) || data.Length == 0)
            {
                head = null;
            }
            else
            {
                foreach (var item in data)
                {
                    Add(item);
                }
            }
        }

        public void Add(T data)
        {
            if (ReferenceEquals(data, null))
            {
                throw new NullReferenceException("Попытка добавить null в бинарное дерево поиска");
            }

            if (Equals(head, null))
            {
                head = new TreenNode<T>(data);
                return;
            }

            var p = head;

            while (true)
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

        public TreenNode<T> FindNode(T data)
        {
            if (ReferenceEquals(data, null))
            {
                throw new ArgumentNullException("Попытка найти null элемент");
            }

            var p = head;
            while (true)
            {
                if (Equals(p.value, data))
                {
                    return p;
                }
                else if (p.value.CompareTo(data) > 0)
                {
                    if (!ReferenceEquals(p.Left, null))
                    {
                        p = p.Left;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (!ReferenceEquals(p.Right, null))
                    {
                        p = p.Right;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        /*public T GoThroughWide() //FUNC
        {
            var queue = new Queue<TreenNode<T>>();

            queue.Enqueue(head);

            while (queue.Count != 0)
            {
                var element = queue.Dequeue();

                //WORK

                if (element.Left != null)// Поменять на ?.
                {
                    queue.Enqueue(element.Left);
                }

                if (element.Right != null)
                {
                    queue.Enqueue(element.Right)
                }
                queue.Enqueue(element.Left);
            }
        }*/
    }
}
