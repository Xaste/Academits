using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class MyList<T>
    {
        private ListItem<T> head;

        public int ListLength { get; private set; }


        public MyList(params T[] data)
        {
            if (data.Length == 0)
            {
                head = null;
            }
            else if (data.Length == 1)
            {
                head = new ListItem<T>(data[0], null);
            }
            else
            {
                head = new ListItem<T>(data[0], new ListItem<T>());
                var p = head.Next;

                for (var i = 1; i < data.Length; i++)
                {
                    p.Data = data[i];

                    if (i < data.Length - 1)
                    {
                        p.Next = new ListItem<T>();
                        p = p.Next;
                    }
                }
            }

            ListLength = data.Length;
        }

        public MyList(MyList<T> list)
        {
            if (list.head == null)
            {
                head = list.head;
                this.ListLength = list.ListLength;
            }
            else
            {
                head = new ListItem<T>(list.head.Data, new ListItem<T>());
                var p = head.Next;

                for (var i = 1; i < list.ListLength; i++)
                {
                    p.Data = list.GetElementByIndex(i);

                    if (i < list.ListLength - 1)
                    {
                        p.Next = new ListItem<T>();
                        p = p.Next;
                    }
                }

                this.ListLength = list.ListLength;
            }
        }

        private ListItem<T> GetLinkByIndex(int index)
        {
            var n = 0;
            var p = head;

            while (n != index)
            {
                ++n;
                p = p.Next;
            }

            return p;
        }

        private ListItem<T> GetPreviusLinkByIndex(int index)
        {
            var i = 0;
            var p = head;

            while (i != index - 1)
            {
                ++i;
                p = p.Next;
            }

            return p;
        }

        private ListItem<T> GetPreviusLinkByData(T data)
        {
            var p = head;
            var previous = head;

            while (!ReferenceEquals(p, null))
            {
                if (p.Data.Equals(data))
                {
                    return previous;
                }

                previous = p;
                p = p.Next;
            }

            return null;
        }

        private bool RemoveElementByPreviousLink(ListItem<T> link)
        {
            if (link == null)
            {
                return false;
            }

            link.Next = link.Next.Next;

            --ListLength;

            return true;
        }

        public T GetFirstElement()
        {
            if (ReferenceEquals(head, null))
            {
                throw new InvalidOperationException("Список пуст");
            }
            return head.Data;
        }

        public T GetElementByIndex(int n)
        {
            if (n < 0 || n >= ListLength)
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таким индексом");
            }

            return GetLinkByIndex(n).Data;

        }

        public T SetElementByIndex(int n, T newData)
        {
            if (n < 0 || n >= ListLength)
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таким индексом");
            }

            var p = GetLinkByIndex(n);

            var oldData = p.Data;
            p.Data = newData;

            return oldData;
        }

        public T RemoveElementByIndex(int n)
        {
            if (n < 0 || n >= ListLength)
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таким индексом");
            }

            if (n == 0)
            {
                return RemoveFirstElement();
            }

            var p = GetPreviusLinkByIndex(n);

            var deleteValue = p.Next.Data;

            RemoveElementByPreviousLink(p);

            return deleteValue;
        }

        public void InsertFirstElement(T data)
        {
            head = new ListItem<T>(data, head);

            ++ListLength;
        }

        public void InsertElementByIndex(int n, T data)
        {
            if (n == 0)
            {
                InsertFirstElement(data);
                return;
            }

            if (n < 0 || n > ListLength)
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таким индексом");
            }
            else
            {
                var p = GetLinkByIndex(n - 1);
                var insert = new ListItem<T>(data, p.Next);
                p.Next = insert;

                ++ListLength;
            }
        }

        public bool RemoveElementByData(T data)
        {
            var p = GetPreviusLinkByData(data);

            if (p == head)
            {
                RemoveFirstElement();
                return true;
            }

            return RemoveElementByPreviousLink(p);

        }

        public T RemoveFirstElement()
        {
            if (ReferenceEquals(head, null))
            {
                throw new InvalidOperationException("Список пуст");
            }

            var answer = head.Data;
            head = head.Next;

            --ListLength;

            return answer;
        }

        public void ReverseList()
        {
            if (ReferenceEquals(head, null))
            {
                throw new InvalidOperationException("Список пуст");
            }

            var first = head;
            var middle = head.Next;
            var last = middle.Next;

            first.Next = null;
            while (last != null)
            {
                middle.Next = first;
                first = middle;
                middle = last;
                last = last.Next;
            }

            middle.Next = first;

            head = middle;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();


            var p = head;
            for (; p.Next != null; p = p.Next)
            {
                sb.Append(p.Data);
                sb.Append(", ");
            }

            sb.Append(p.Data);

            return sb.ToString();
        }
    }
}
