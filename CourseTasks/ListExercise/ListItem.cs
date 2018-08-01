using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class ListItem<T>
    {
        private T data;
        private ListItem<T> next;

        public T Data { get => data; set => data = value; }

        public ListItem()
        {

        }

        public ListItem(T data)
        {
            this.Data = data;
        }

        public ListItem(T data, ListItem<T> next)
        {
            this.Data = data;
            this.next = next;
        }

        public ListItem<T> GetNext()
        {
            return next;
        }

        public void SetNext(ListItem<T> next)
        {
            this.next = next;
        }
    }
}
