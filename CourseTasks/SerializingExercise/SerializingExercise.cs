using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializingExercise
{
    class SerializingExercise
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 2);

            BinaryFormatter formatter = new BinaryFormatter();

            using (var output = new FileStream("out.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(output, rectangle);
            }

            Rectangle result;
            using (var strem = new FileStream("out.bin", FileMode.Open, FileAccess.Read))
            {
                result = (Rectangle)formatter.Deserialize(strem);
            }

            Console.WriteLine();
        }
    }
}
