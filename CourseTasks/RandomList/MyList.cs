using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class MyList<T>
    {
        private ListItem<T> _head;

        public void SetHead(ListItem<T> head)
        {
            _head = head;
        }
    }
}
