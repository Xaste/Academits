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
            using (var stream = new FileStream("out.bin", FileMode.Open, FileAccess.Read))
            {
                result = (Rectangle)formatter.Deserialize(stream);
            }

            Console.WriteLine();

            var matrix1 = new MatrixDefaultSerializable(new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 6, 7, 8 }, new int[] { 3, 6, 1, 9, 10 }, new int[] { 4, 7, 9, 1, 11 }, new int[] { 5, 8, 10, 11, 1 } });

            using (var outputMatrix1 = new FileStream("matrixOut.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(outputMatrix1, matrix1);
            }

            MatrixDefaultSerializable matrixResult1;

            using (var stream2 = new FileStream("matrixOut.bin", FileMode.Open, FileAccess.Read))
            {
                matrixResult1 = (MatrixDefaultSerializable)formatter.Deserialize(stream2);
            }

            var matrix2 = new MatrixCustomSerializable(new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 6, 7, 8 }, new int[] { 3, 6, 1, 9, 10 }, new int[] { 4, 7, 9, 1, 11 }, new int[] { 5, 8, 10, 11, 1 } });

            using (var outputMatrix2 = new FileStream("matrixOut2.bin", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(outputMatrix2, matrix2);
            }

            MatrixCustomSerializable matrixResult2;

            using (var stream3 = new FileStream("matrixOut2.bin", FileMode.Open, FileAccess.Read))
            {
                matrixResult2 = (MatrixCustomSerializable)formatter.Deserialize(stream3);
            }

            Console.WriteLine();
        }
    }
}
