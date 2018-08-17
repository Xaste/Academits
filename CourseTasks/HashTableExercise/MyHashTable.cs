using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercise
{
    class MyHashTable<T> : ICollection<T>
    {
        private List<T>[] items = new List<T>[100];

        public int Count { get; private set; }
        public bool IsReadOnly { get; }
        private int modCount = 0;

        private const int IndexForNull = 0;

        public MyHashTable(params T[] data)
        {
            foreach (var e in data)
            {
                Add(e);
            }

            Count = data.Length;
        }

        public MyHashTable(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Размерность массива не может быть меньше 0");
            }

            items = new List<T>[capacity];
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var startModCount = modCount;
            foreach (var t in items)
            {
                if (ReferenceEquals(t, null))
                {
                    continue;
                }

                foreach (var e in t)
                {
                    if (modCount != startModCount)
                    {
                        throw new InvalidOperationException("Список изменился за время обхода");
                    }

                    yield return e;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            var index = ReferenceEquals(item, null) ? IndexForNull : Math.Abs(item.GetHashCode() % items.Length);

            if (ReferenceEquals(items[index], null))
            {
                items[index] = new List<T>();
            }

            items[index].Add(item);

            ++Count;
            ++modCount;
        }

        public void Clear()
        {
            for (var i = 0; i < items.Length; i++)
            {
                if (ReferenceEquals(items[i], null))
                {
                    continue;
                }

                items[i].Clear();
            }

            Count = 0;
            ++modCount;
        }

        public bool Contains(T item)
        {
            var index = ReferenceEquals(item, null) ? IndexForNull : Math.Abs(item.GetHashCode() % items.Length);

            if (ReferenceEquals(items[index], null) || items[index].Count == 0)
            {
                return false;
            }

            foreach (var e in items[index])
            {
                if (Equals(item, e))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (ReferenceEquals(array, null))
            {
                throw new ArgumentNullException("Ссылка на массив null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("индекс меньше 0");
            }
            if (Count > array.Length - arrayIndex)
            {
                throw new ArgumentException("передаваемый массив больше доступного места в целевом массиве");
            }

            var i = arrayIndex;

            foreach (var e in this)
            {
                array[i] = e;
                i++;
            }
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            var index = ReferenceEquals(item, null) ? IndexForNull : Math.Abs(item.GetHashCode() % items.Length);

            items[index].Remove(item);

            --Count;
            ++modCount;

            return true;
        }

    }
}
