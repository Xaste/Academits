﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise
{
    class ListItem<T>
    {
        public ListItem<T> Next { get; set; }

        public T Data { get; set; }

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
            this.Next = next;
        }
    }
}
