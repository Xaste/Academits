using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileExercise
{
    class TextFileExercise
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[] str;

            using (StreamReader reader = new StreamReader("Input.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    ++count;
                }

                reader.BaseStream.Position = 0;

                str = new string[count];

                for (int i = 0; i < str.Length; i++)
                {
                    str[i] = reader.ReadLine();
                }
            }

            foreach (var e in str)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            using (StreamReader reader = new StreamReader("Input.txt"))
            {
                StringBuilder st = new StringBuilder();
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    st.Append(line);
                    st.Append(Environment.NewLine);
                }

                var str1 = Convert.ToString(st);

                var str2 = str1.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in str2)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
