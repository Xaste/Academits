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
        private const int DefaultCapacity = 10;

        private T[] items = new T[DefaultCapacity];
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

                modCount++;
            }
        }

        public MyList() { }

        public MyList(params T[] array)
        {
            items = new T[array.Length];
            Array.Copy(array, items, array.Length);

            Count = array.Length;
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Начальный размер массива не может быть меньше нуля");
            }

            items = new T[capacity];
        }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (Count >= items.Length)
            {
                IncreaseCapacity();
            }

            items[Count] = item;
            ++Count;
            modCount++;
        }

        private void IncreaseCapacity()
        {
            const int minLengthIncrease = 50;

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
            Count = 0;
            ++modCount;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) >= 0;
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

            Array.Copy(items, 0, array, arrayIndex, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var startModCount = modCount;

            for (var i = 0; i < Count; i++)
            {
                if (modCount != startModCount)
                {
                    throw new InvalidOperationException("Список изменился за время обхода");
                }
                yield return items[i];
            }
        }

        public int IndexOf(T item)
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
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("Невозможно добавить объект в указанный индекс");
            }

            if (Count >= items.Length - 1)
            {
                IncreaseCapacity();
            }

            Array.Copy(items, index, items, index + 1, Count - index);
            items[index] = item;

            Count++;
            modCount++;
        }

        public bool Remove(T item)
        {
            var index = IndexOf(item);

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
            modCount++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int EnsureCapacity(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException("Длина массива не может быть меньше 0");
            }
            if (items.Length >= capacity)
            {
                return items.Length;
            }

            Array.Resize(ref items, capacity);
            return items.Length;
        }

        public void TrimToSize()
        {
            if (Count == 0)
            {
                Array.Resize(ref items, DefaultCapacity);
            }
            else if (items.Length > Count)
            {
                Array.Resize(ref items, Count);
            }
        }
    }
}
