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

        private int listLength;

        public int ListLength
        {
            get => listLength;
        }

        public MyList(params T[] data)
        {
            if (data.Length == 1)
            {
                head = new ListItem<T>(data[0], null);
            }
            else
            {
                head = new ListItem<T>(data[0], new ListItem<T>());
                var p = head.GetNext();

                for (var i = 1; i < data.Length; i++)
                {
                    p.Data = data[i];

                    if (i < data.Length - 1)
                    {
                        p.SetNext(new ListItem<T>());
                        p = p.GetNext();
                    }
                }
            }

            listLength = data.Length;
        }

        public MyList(MyList<T> list)
        {
            head = new ListItem<T>(list.head.Data, new ListItem<T>());
            var p = head.GetNext();

            for (var i = 1; i < list.ListLength; i++)
            {
                p.Data = list.GetElementByIndex(i);

                if (i < list.ListLength - 1)
                {
                    p.SetNext(new ListItem<T>());
                    p = p.GetNext();
                }
            }

            this.listLength = list.ListLength;
        }

        private ListItem<T> GetLink(int index)
        {
            var n = 0;
            var p = head;

            while (n != index)
            {
                ++n;
                p = p.GetNext();
            }

            return p;
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

            if (n == 0)
            {
                return GetFirstElement();
            }

            return GetLink(n).Data;

        }

        public T SetElementByIndex(int n, T newData)
        {
            if (n < 0 || n >= ListLength)
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таким индексом");
            }

            var p = GetLink(n);

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

            var p = GetLink(n - 1);

            var deleteValue = p.GetNext().Data;

            p.SetNext(p.GetNext().GetNext());

            --listLength;

            return deleteValue;
        }

        public void InsertFirstElement(T data)
        {
            head = new ListItem<T>(data, head);

            ++listLength;
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
                var p = GetLink(n - 1);
                var insert = new ListItem<T>(data, p.GetNext());
                p.SetNext(insert);
                ++listLength;
            }
        }

        private ListItem<T> GetLink(T data, out int index)
        {
            var p = head;
            index = 0;

            while (!(ReferenceEquals(p, null)) && !(p.Data.Equals(data)))
            {
                ++index;
                p = p.GetNext();
            }

            return p;
        }

        public bool RemoveElementByData(T data)
        {
            var p = GetLink(data, out int index);

            if (p == null)
            {
                return false;
            }

            RemoveElementByIndex(index);

            return true;
        }

        public T RemoveFirstElement()
        {
            var answer = head.Data;
            head = head.GetNext();

            --listLength;

            return answer;
        }

        public void ReverseList()
        {
            var first = head;
            var middle = head.GetNext();
            var last = middle.GetNext();

            first.SetNext(null);
            while (last != null)
            {
                middle.SetNext(first);
                first = middle;
                middle = last;
                last = last.GetNext();
            }

            middle.SetNext(first);

            head = middle;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var p = head; p != null; p = p.GetNext())
            {
                sb.Append(p.Data);
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
