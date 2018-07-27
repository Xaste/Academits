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
            try
            {
                using (StreamReader reader = new StreamReader("input.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        arrayList.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл input.txt не найден.");
            }

            var arrayListInt1 = new List<int> { 2, 22, 15, 17, 338, 0, 17, 22 };

            for (var i = 0; i < arrayListInt1.Count; i++)
            {
                if (arrayListInt1[i] % 2 == 0)
                {
                    arrayListInt1.RemoveAt(i);
                    --i;
                }
            }

            var arrayListRepeat = new List<int> { 1, 5, 2, 1, 3, 5 };

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
