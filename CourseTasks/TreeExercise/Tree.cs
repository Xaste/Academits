using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Tree<T> where T : IComparable
    {
        private TreeNode<T> head;

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
                head = new TreeNode<T>(data);
                return;
            }

            var p = head;

            while (true)
            {
                if (p.value.CompareTo(data) > 0)
                {
                    if (ReferenceEquals(p.Left, null))
                    {
                        p.Left = new TreeNode<T>(data);
                        break;
                    }

                    p = p.Left;
                }
                else
                {
                    if (ReferenceEquals(p.Right, null))
                    {
                        p.Right = new TreeNode<T>(data);
                        break;
                    }

                    p = p.Right;
                }
            }
        }

        public TreeNode<T> GetPreviousNode(T data)//TODO Сделать private
        {
            if (ReferenceEquals(data, null))
            {
                throw new ArgumentNullException("Попытка найти null элемент");
            }

            var p = head;
            TreeNode<T> previous = null;
            while (true)
            {
                if (Equals(p.value, data))
                {
                    return previous;
                }
                else if (p.value.CompareTo(data) > 0)
                {
                    if (!ReferenceEquals(p.Left, null))
                    {
                        previous = p;
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
                        previous = p;
                        p = p.Right;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public TreeNode<T> FindNode(T data)
        {
            if (Equals(head.value, data))
            {
                return head;
            }

            var previous = GetPreviousNode(data);

            return Equals(previous.Left.value, data) ? previous.Left : previous.Right;
        }

        public void GoThroughWide(Action<TreeNode<T>> f)
        {
            var queue = new Queue<TreeNode<T>>();

            queue.Enqueue(head);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                f(node);

                if (!Equals(node.Left, null))// Поменять на ?.
                {
                    queue.Enqueue(node.Left);
                }

                if (!Equals(node.Right, null))
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        public int GetCount()
        {
            var i = 0;

            GoThroughWide((x) => i++);

            return i;
        }

        public bool RemoveNode1(T data)
        {
            bool isHeadDelete = false;
            if (Equals(head.value, data))//Удаление корня
            {
                isHeadDelete = true;
            }

            var previous = GetPreviousNode(data);

            var isLeftForPrevious = (Equals(previous.Left.value, data)) ? true : false;

            var targetNode = (isLeftForPrevious) ? previous.Left : previous.Right;

            if (ReferenceEquals(targetNode.Left, null) && ReferenceEquals(targetNode.Right, null))
            {
                if (isHeadDelete)
                {
                    head = null;
                }
                else
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = null;
                    }
                    else
                    {
                        previous.Right = null;
                    }
                }
                return true;
            }
            else if (ReferenceEquals(targetNode.Left, null) || ReferenceEquals(targetNode.Right, null))
            {
                var isOnlyLeftChild = ReferenceEquals(targetNode.Left, null) ? false : true;

                if (!ReferenceEquals(targetNode.Left, null))
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = targetNode.Left;
                    }
                    else
                    {
                        previous.Right = targetNode.Left;
                    }
                }
                else
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = targetNode.Right;
                    }
                    else
                    {
                        previous.Right = targetNode.Right;
                    }
                }

                return true;
            }
            else
            {
                var MostLeftNode = targetNode.Right;
                var previousOfMostLeft = MostLeftNode;
                while (!ReferenceEquals(MostLeftNode.Left, null))
                {
                    previousOfMostLeft = MostLeftNode;
                    MostLeftNode = MostLeftNode.Left;
                }

                previousOfMostLeft.Left = !ReferenceEquals(MostLeftNode.Right, null) ? MostLeftNode.Right : null;

                MostLeftNode.Left = targetNode.Left;
                MostLeftNode.Right = targetNode.Right;

                if (isLeftForPrevious)
                {
                    previous.Left = MostLeftNode;
                }
                else
                {
                    previous.Right = MostLeftNode;
                }

                return true;
            }

            return false;
        }

        private bool RemoveNodeWithoutChilds(TreeNode<T> previous, bool isLeftFromPrevious)
        {
            if (ReferenceEquals(previous, null))//удаляем корень
            {

            }
            else
            {

            }
        }

        public bool RemoveNode(T data)
        {
            bool isHeadDelete = false;
            if (Equals(head.value, data))//Удаление корня
            {
                isHeadDelete = true;
            }

            var previous = GetPreviousNode(data);

            var isLeftForPrevious = (Equals(previous.Left.value, data)) ? true : false;

            //var targetNode = (isLeftForPrevious) ? previous.Left : previous.Right;

            if (ReferenceEquals(targetNode.Left, null) && ReferenceEquals(targetNode.Right, null))
            {
                RemoveNodeWithoutChilds(previous, isLeftForPrevious);
                if (isHeadDelete)
                {
                    head = null;
                }
                else
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = null;
                    }
                    else
                    {
                        previous.Right = null;
                    }
                }
                return true;
            }
            else if (ReferenceEquals(targetNode.Left, null) || ReferenceEquals(targetNode.Right, null))
            {
                var isOnlyLeftChild = ReferenceEquals(targetNode.Left, null) ? false : true;

                if (!ReferenceEquals(targetNode.Left, null))
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = targetNode.Left;
                    }
                    else
                    {
                        previous.Right = targetNode.Left;
                    }
                }
                else
                {
                    if (isLeftForPrevious)
                    {
                        previous.Left = targetNode.Right;
                    }
                    else
                    {
                        previous.Right = targetNode.Right;
                    }
                }

                return true;
            }
            else
            {
                var MostLeftNode = targetNode.Right;
                var previousOfMostLeft = MostLeftNode;
                while (!ReferenceEquals(MostLeftNode.Left, null))
                {
                    previousOfMostLeft = MostLeftNode;
                    MostLeftNode = MostLeftNode.Left;
                }

                previousOfMostLeft.Left = !ReferenceEquals(MostLeftNode.Right, null) ? MostLeftNode.Right : null;

                MostLeftNode.Left = targetNode.Left;
                MostLeftNode.Right = targetNode.Right;

                if (isLeftForPrevious)
                {
                    previous.Left = MostLeftNode;
                }
                else
                {
                    previous.Right = MostLeftNode;
                }

                return true;
            }

            return false;
        }
    }
}
