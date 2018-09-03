using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputExercise
{
    class InputOutputExercise
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(new FileStream("f.txt", FileMode.Create, FileAccess.Write)))
            {
                for (int i = 1; i <= 100; i++)
                {
                    writer.WriteLine($"Строка {i}");
                }

                writer.WriteLine("End");
                writer.Write("...");
            }

            byte[] res = new byte[1000000];
            var size = 0;

            using (var input = new BinaryReader(new FileStream("f.txt", FileMode.Open, FileAccess.Read)))
            {
                var read = 0;
                var off = 0;


                while ((read = input.Read(res, off, res.Length - off)) > 0)
                {
                    off += read;
                }

                size = off;
            }

            using (var output = new BinaryWriter(new FileStream("out.txt", FileMode.Create, FileAccess.Write)))
            {
                output.Write(res, 0, size);
            }
        }
    }
}
