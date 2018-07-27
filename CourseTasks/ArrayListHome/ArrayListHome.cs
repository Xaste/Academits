using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayListHome
{
    class ArrayListHome
    {
        static void Main(string[] args)
        {
            var arrayList = new List<string>();

            using (StreamReader reader = new StreamReader("input.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    arrayList.Add(line);
                }
            }

            var arrayListInt = new List<int>() { 1, 22, 15, 17, 338 };

            for (int i = 0; i < arrayListInt.Count; i++)
            {
                if (arrayListInt[i] % 2 == 0)
                {
                    arrayListInt.RemoveAt(i);
                }
            }

            var arrayListRepeat = new List<int>() { 1, 5, 2, 1, 3, 5 };

            var arrayListNoRepeat = new List<int>();

            foreach (var item in arrayListRepeat)
            {
                if (arrayListNoRepeat.Contains(item))
                {
                    continue;
                }

                arrayListNoRepeat.Add(item);
            }
        }
    }
}
