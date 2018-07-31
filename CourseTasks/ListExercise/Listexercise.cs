﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ListExercise
{
    class ListExercise
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>(new int[] { 1, 2, 3, 4, 5 });

            var length = list.GetListLength();
            Console.WriteLine(length);
            Console.WriteLine();

            var firstElement = list.GetFirstElement();
            Console.WriteLine(firstElement);
            Console.WriteLine();

            var thirdElement = list.GetElementByIndex(2);
            Console.WriteLine(thirdElement);
            Console.WriteLine();

            var oldData = list.SetElementByIndex(1, 22);
            Console.WriteLine(oldData);
            Console.WriteLine(list);
            Console.WriteLine();

            var removedData = list.RemoveElementByIndex(0);
            Console.WriteLine($"Removed Data: {removedData}");
            Console.WriteLine(list);
            Console.WriteLine();

            list.InsertElementByIndex(0, 1);
            Console.WriteLine(list);
            Console.WriteLine();

            list.InsertFirstElement(55);
            Console.WriteLine(list);

            var isRemoved = list.RemoveElementByData(11);
            Console.WriteLine(isRemoved);
            Console.WriteLine(list);

            list.RemoveElementByData(55);
            list.SetElementByIndex(1, 2);
            Console.WriteLine(list);

            list.ReverseList();

            var list2 = new MyList<int>(list);
        }
    }
}