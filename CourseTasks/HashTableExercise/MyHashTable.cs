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

        public int Count { get; }
        public bool IsReadOnly { get; }

        public MyHashTable(params T[] data)
        {
            foreach (var e in data)
            {
                Add(e);
            }
        }

        public MyHashTable(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Размерность массива не может быть меньше 0");
            }

            items = new List<T>[capacity];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var t in items)
            {
                foreach (var VARIABLE in t)
                {
                    yield return VARIABLE;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            if (ReferenceEquals(item, null))
            {
                throw new NullReferenceException("В хэщтаблицу нельзя добавить null");//TODO А точно нельзя?
            }

            var index = Math.Abs(item.GetHashCode() % items.Length);

            if (ReferenceEquals(items[index], null))
            {
                items[index] = new List<T>();
            }

            items[index].Add(item);
        }

        public void Clear()
        {
            for (var i = 0; i < items.Length; i++)
            {
                items[i].Clear();
            }
        }

        public bool Contains(T item)
        {
            var index = Math.Abs(item.GetHashCode() % items.Length);

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
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            var index = Math.Abs(item.GetHashCode() % items.Length);
            items[index].Remove(item);

            return true;
        }

    }
}
