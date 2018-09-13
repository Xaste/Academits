using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Tree<T>
    {
        private TreeNode<T> head;
        private IComparer<T> comparer = Comparer<T>.Default;
        public int Count { get; private set; }

        public Tree(params T[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("В дерево должно быть передано хотя бы 1 значение");
            }

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

            Count = data.Length;
        }

        public Tree(IComparer<T> comparer, params T[] data)
        {
            if (data.Length == 0)
            {
                throw new ArgumentException("В дерево должно быть передано хотя бы 1 значение");
            }

            if (Equals(data, null) || data.Length == 0)
            {
                head = null;
            }

            this.comparer = comparer;

            Count = data.Length;
        }

        public void Add(T data)
        {
            if (Equals(head, null))
            {
                head = new TreeNode<T>(data);
                return;
            }

            var p = head;

            while (true)
            {
                if (comparer.Compare(data, p.Value) < 0)
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

            Count++;
        }

        private TreeNode<T> GetPreviousNode(T data)
        {
            var p = head;
            TreeNode<T> previous = null;

            while (true)
            {
                if (comparer.Compare(p.Value, data) == 0)
                {
                    return previous;
                }
                else if (comparer.Compare(data, p.Value) < 0)
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
            if (comparer.Compare(head.Value, data) == 0)
            {
                return head;
            }

            var previous = GetPreviousNode(data);

            return comparer.Compare(previous.Left.Value, data) == 0 ? previous.Left : previous.Right;
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

        public bool RemoveNode(T data)
        {
            var isHeadDelete = comparer.Compare(head.Value, data) == 0;

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
                targetNode = comparer.Compare(previous.Left.Value, data) == 0 ? previous.Left : previous.Right;
            }

            if (ReferenceEquals(targetNode.Left, null) && ReferenceEquals(targetNode.Right, null))
            {
                if (isHeadDelete)
                {
                    head = null;
                }
                else
                {
                    if (comparer.Compare(previous.Left.Value, data) == 0)
                    {
                        previous.Left = null;
                    }
                    else
                    {
                        previous.Right = null;
                    }
                }

                --Count;
                return true;
            }

            if (ReferenceEquals(targetNode.Left, null) || ReferenceEquals(targetNode.Right, null))
            {
                if (isHeadDelete)
                {
                    head = targetNode.Left ?? targetNode.Right;

                    --Count;

                    return true;
                }

                if (!ReferenceEquals(targetNode.Left, null))
                {
                    if (comparer.Compare(previous.Left.Value, data) == 0)
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
                    if (comparer.Compare(previous.Left.Value, data) == 0)
                    {
                        previous.Left = targetNode.Right;
                    }
                    else
                    {
                        previous.Right = targetNode.Right;
                    }
                }

                --Count;

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
                if (comparer.Compare(previous.Left.Value, data) == 0)
                {
                    previous.Left = mostLeftNode;
                }
                else
                {
                    previous.Right = mostLeftNode;
                }
            }

            --Count;

            return true;
        }
    }
}
