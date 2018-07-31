using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class MyList<T>
    {
        private ListItem<T> head;

        public MyList(params T[] data)
        {
            head = new ListItem<T>(data[0], new ListItem<T>());
            var p = head.GetNext();

            for (var i = 1; i < data.Length; i++)
            {
                p.SetData(data[i]);

                if (i < data.Length - 1)
                {
                    p.SetNext(new ListItem<T>());
                    p = p.GetNext();
                }
            }
        }

        public int GetListLength()
        {
            var count = 1;
            var p = head;

            while (p.GetNext() != null)
            {
                ++count;
                p = p.GetNext();
            }

            return count;
        }

        public T GetFirstElement()
        {
            return head.GetData();
        }
    }
}
