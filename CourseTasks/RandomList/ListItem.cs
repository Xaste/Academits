using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class ListItem<T>
    {
        public ListItem<T> Next { get; set; }

        public ListItem<T> Random { get; set; }

        public T Data { get; set; }

        public ListItem(T data)
        {
            this.Data = data;
        }

        public ListItem(T data, ListItem<T> next, ListItem<T> random)
        {
            this.Data = data;
            this.Next = next;
            this.Random = random;
        }

        public ListItem<T> Copy()
        {
            var rez = new ListItem<T>(Data, Next, Random);

            return rez;
        }
    }
}
