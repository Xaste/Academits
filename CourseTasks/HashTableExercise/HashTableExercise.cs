using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExercise
{
    class HashTableExercise
    {
        static void Main(string[] args)
        {
            var table1 = new MyHashTable<int>(new int[] { 22, 13, 55, 77, 8000 });

            table1.Contains(223);
            table1.Contains(8000);
            table1.Remove(8000);

            table1.Add(8000);
            table1.Add(8000);

            table1.Remove(8000);
            table1.Remove(1);

            foreach (var e in table1)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            var array1 = new int[10];
            table1.CopyTo(array1, 5);

            foreach (var e in array1)
            {
                Console.WriteLine(e);
            }

            var readOnly = table1.IsReadOnly;

            table1.Clear();

            table1 = new MyHashTable<int>(new int[] { });

            var table2 = new MyHashTable<string>(5);
            table2.Contains("111");


            table2.Add("111");
            table2.Add(null);
            table2.Contains("123");
            table2.Contains(null);
            
            table2.Clear();
            table2.Contains(null);
            table2.Add("121da");

            var array2 = new string[10];
            table2.CopyTo(array2, 0);

            foreach (var e in table2)
            {
                Console.WriteLine(e);
            }
        }
    }
}
