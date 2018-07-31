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

        public MyList(T data)
        {
            head = new ListItem<T>(data);
        }

        //public SetNext
    }
}
