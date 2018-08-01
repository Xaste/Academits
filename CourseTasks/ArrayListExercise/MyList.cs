using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExercise
{
    class MyList<T> : IList<T>
    {
        private T[] items = new T[10];
        private int length;

        public int Count
        {
            get
            {
                return length;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                {
                    throw new ArgumentOutOfRangeException("Элемента с таким индексом не существует");
                }
                return items[index];
            }

            set
            {
                if (index < 0 || index >= length)
                {
                    throw new ArgumentOutOfRangeException("Элемента с таким индексом не существует");
                }
                items[index] = value;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (length >= items.Length)
            {
                IncreaseCapacity();
            }

            items[length] = item;
            ++length;
        }

        private void IncreaseCapacity()
        {
            Array.Resize(ref items, items.Length * 2);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
