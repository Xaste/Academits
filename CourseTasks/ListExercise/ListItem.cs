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

        public ListItem()
        {

        }

        public ListItem(T data)
        {
            this.data = data;
        }

        public ListItem(T data, ListItem<T> next)
        {
            this.data = data;
            this.next = next;
        }

        public T GetData()
        {
            return data;
        }

        public void SetData(T data)
        {
            this.data = data;
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
