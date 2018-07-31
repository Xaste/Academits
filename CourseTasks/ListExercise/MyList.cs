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

        public MyList(params T[] data)
        {
            head = new ListItem<T>(data[0], new ListItem<T>());
            var p = head.GetNext();

            for (var i = 1; i < data.Length; i++)
            {
                p.SetData(data[i]);

                if (i < data.Length - 1)
                {
                    p.SetNext(new ListItem<T>());
                    p = p.GetNext();
                }
            }
        }

        public MyList(MyList<T> list)
        {
            head = new ListItem<T>(list.head.GetData(), new ListItem<T>());
            var p = head.GetNext();

            for (var i = 1; i < list.GetListLength(); i++)
            {
                p.SetData(list.GetElementByIndex(i));

                if (i < list.GetListLength() - 1)
                {
                    p.SetNext(new ListItem<T>());
                    p = p.GetNext();
                }
            }
        }

        public int GetListLength()
        {
            var count = 1;
            var p = head;

            while (p.GetNext() != null)
            {
                ++count;
                p = p.GetNext();
            }

            return count;
        }

        public T GetFirstElement()
        {
            return head.GetData();
        }

        public T GetElementByIndex(int n)
        {
            if (n < 0 || n >= GetListLength())
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таим индексом");
            }

            if (n == 0)
            {
                return GetFirstElement();
            }

            var index = 0;
            var p = head;

            while (index != n)
            {
                ++index;
                p = p.GetNext();
            }

            return p.GetData();
        }

        public T SetElementByIndex(int n, T newData)
        {
            if (n < 0 || n >= GetListLength())
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таим индексом");
            }

            var index = 0;
            var p = head;

            while (index != n)
            {
                ++index;
                p = p.GetNext();
            }

            var oldData = p.GetData();
            p.SetData(newData);

            return oldData;
        }

        public T RemoveElementByIndex(int n)
        {
            if (n < 0 || n >= GetListLength())
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таим индексом");
            }
            if (n == 0)
            {
                return RemoveFirstElement();
            }

            var index = 0;
            var p = head;
            var previous = p;

            while (index != n)
            {
                ++index;
                previous = p;
                p = p.GetNext();
            }

            previous.SetNext(p.GetNext());

            return p.GetData();
        }

        public void InsertFirstElement(T data)
        {
            head = new ListItem<T>(data, head);
        }

        public void InsertElementByIndex(int n, T data)
        {
            if (n < 0 || n >= GetListLength())
            {
                throw new IndexOutOfRangeException("В списке нет элемента с таим индексом");
            }

            var index = 0;
            var p = head;
            var previous = p;

            if (n == 0)
            {
                InsertFirstElement(data);
            }
            else
            {
                while (index != n)
                {
                    ++index;
                    previous = p;
                    p = p.GetNext();
                }

                var insert = new ListItem<T>(data, p);
                previous.SetNext(insert);
            }
        }

        public bool RemoveElementByData(T data)
        {
            var p = head;
            var index = 0;
            var previous = p;

            while (!(p is null) && !(p.GetData().Equals(data)))
            {
                ++index;
                previous = p;
                p = p.GetNext();
            }

            if (p == null)
            {
                return false;
            }

            this.RemoveElementByIndex(index);
            return true;
        }

        public T RemoveFirstElement()
        {
            var answer = head.GetData();
            head = head.GetNext();
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
                sb.Append(p.GetData());
                sb.Append(" ");
            }

            return sb.ToString();
        }
    }
}
