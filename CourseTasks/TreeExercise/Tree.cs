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
                if (p.Value.CompareTo(data) > 0)
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

        private TreeNode<T> GetPreviousNode(T data)
        {
            if (ReferenceEquals(data, null))
            {
                throw new ArgumentNullException("Попытка найти null элемент");
            }

            var p = head;
            TreeNode<T> previous = null;

            while (true)
            {
                if (Equals(p.Value, data))
                {
                    return previous;
                }
                else if (p.Value.CompareTo(data) > 0)
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
            if (Equals(head.Value, data))
            {
                return head;
            }

            var previous = GetPreviousNode(data);

            return Equals(previous.Left.Value, data) ? previous.Left : previous.Right;
        }

        public void GoThroughWide(Action<TreeNode<T>> f)
        {
            var queue = new Queue<TreeNode<T>>();

            queue.Enqueue(head);

            while (queue.Count != 0)
            {
                var node = queue.Dequeue();

                f(node);

                if (!Equals(node.Left, null))
                {
                    queue.Enqueue(node.Left);
                }

                if (!Equals(node.Right, null))
                {
                    queue.Enqueue(node.Right);
                }
            }
        }

        public void GoThroughDeepRecursion(Action<TreeNode<T>> f)
        {
            var p = head;
            VisitNodeForDeepRecursion(f, p);
        }

        private static void VisitNodeForDeepRecursion(Action<TreeNode<T>> f, TreeNode<T> node)
        {
            f(node);

            foreach (var treeNode in node.GetChildren())
            {
                VisitNodeForDeepRecursion(f, treeNode);
            }
        }

        public void GoThroughDeep(Action<TreeNode<T>> f)
        {
            var stack = new Stack<TreeNode<T>>();

            stack.Push(head);

            while (stack.Count != 0)
            {
                var node = stack.Pop();

                f(node);

                if (!ReferenceEquals(node.Right, null))
                {
                    stack.Push(node.Right);
                }

                if (!ReferenceEquals(node.Left, null))
                {
                    stack.Push(node.Left);
                }
            }
        }

        public int GetCount()
        {
            var i = 0;

            GoThroughWide((x) => i++);

            return i;
        }

        public bool RemoveNode(T data)
        {
            var isHeadDelete = Equals(head.Value, data);

            var previous = GetPreviousNode(data);

            if (!isHeadDelete && ReferenceEquals(GetPreviousNode(data), null))
            {
                return false;
            }

            TreeNode<T> targetNode;

            if (isHeadDelete)
            {
                targetNode = head;
            }
            else
            {
                targetNode = Equals(previous.Left.Value, data) ? previous.Left : previous.Right;
            }

            if (ReferenceEquals(targetNode.Left, null) && ReferenceEquals(targetNode.Right, null))
            {
                if (isHeadDelete)
                {
                    head = null;
                }
                else
                {
                    if (Equals(previous.Left.Value, data))
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

            if (ReferenceEquals(targetNode.Left, null) || ReferenceEquals(targetNode.Right, null))
            {
                if (isHeadDelete)
                {
                    head = targetNode.Left ?? targetNode.Right;
                    return true;
                }

                if (!ReferenceEquals(targetNode.Left, null))
                {
                    if (Equals(previous.Left.Value, data))
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
                    if (Equals(previous.Left.Value, data))
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

            var mostLeftNode = targetNode.Right;

            var previousOfMostLeft = mostLeftNode;

            while (!ReferenceEquals(mostLeftNode.Left, null))
            {
                previousOfMostLeft = mostLeftNode;
                mostLeftNode = mostLeftNode.Left;
            }

            if (!ReferenceEquals(mostLeftNode.Right, null))
            {
                previousOfMostLeft.Left = mostLeftNode.Right;
                previousOfMostLeft.Right = null;
            }
            else
            {
                previousOfMostLeft.Left = null;
            }

            mostLeftNode.Left = targetNode.Left;
            mostLeftNode.Right = targetNode.Right;

            if (isHeadDelete)
            {
                head = mostLeftNode;
            }
            else
            {
                if (Equals(previous.Left.Value, data))
                {
                    previous.Left = mostLeftNode;
                }
                else
                {
                    previous.Right = mostLeftNode;
                }
            }

            return true;
        }
    }
}
