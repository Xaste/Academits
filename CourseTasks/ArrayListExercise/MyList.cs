﻿using System;
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
        public int Count { get; private set; }
        private int modCount = 0;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Элемента с таким индексом не существует");
                }
                return items[index];
            }

            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new ArgumentOutOfRangeException("Элемента с таким индексом не существует");
                }
                items[index] = value;
            }
        }

        public MyList()
        {

        }

        public MyList(params T[] array)
        {
            items = new T[array.Length];
            Array.Copy(array, items, array.Length);

            Count = array.Length;
        }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (Count >= items.Length)
            {
                IncreaseCapacity();
            }

            items[Count] = item;
            ++Count;
        }

        private void IncreaseCapacity()
        {
            const int minLengthIncrease = 10;

            if (items.Length < minLengthIncrease / 2)
            {
                Array.Resize(ref items, minLengthIncrease);
            }
            else
            {
                Array.Resize(ref items, items.Length * 2);
            }
        }

        public void Clear()
        {
            Array.Resize(ref items, 0);

            Count = 0;
        }

        public bool Contains(T item)
        {
            foreach (var e in items)
            {
                if (e.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
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

            Array.Copy(items, array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Count; i++)
            {
                yield return items[i];
            }
        }

        public int IndexOf(T item)//TODO Должен кидать исключение, если в коллекции добавились, удалились элементы за время обхода
        {
            for (var i = 0; i < Count; i++)
            {
                if (object.Equals(item, items[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("Нет элемента с таким индексом");
            }

            if (Count >= items.Length - 1)
            {
                IncreaseCapacity();
            }
            
            Array.Copy(sourceArray: items, sourceIndex: index, destinationArray: items, destinationIndex: index + 1, length: Count - index - 1);
            items[index] = item;//TODO А если ссылка?

            Count++;
        }

        public bool Remove(T item)
        {
            var index = -1;
            for (var i = 0; i < Count; i++)
            {
                if (Equals(item, items[i]))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                return false;
            }

            RemoveAt(index);
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Элемента с таким индексом не существует");
            }

            if (index < Count - 1)
            {
                Array.Copy(items, index + 1, items, index, Count - index - 1);
            }

            --Count;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
