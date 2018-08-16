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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
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
            items[index].Add(item);
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

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

    }
}
