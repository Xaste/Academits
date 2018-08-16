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

        }
    }
}
