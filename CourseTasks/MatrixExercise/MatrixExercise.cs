using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorExercise;

namespace MatrixExercise
{
    class MatrixExercise
    {
        static void Main(string[] args)
        {
            var matrix1 = new Matrix(5, 4);

            var array1 = new double[][] { new double[] { 1, 2, 3 }, new double[] { 2, 3, 4 }, new double[] { 1, 2 }, new double[] { 1 } };
            var array2 = new double[] { 17, 22, 33, 14, 5 };
            var array3 = new double[] { 1, 2, 3, 4 };

            var matrix2 = new Matrix(array1);

            var matrix3 = new Matrix(matrix2);

            var vectorArray = new Vector[] { new Vector(5), new Vector(array2) };

            var vector = matrix3.GetVectorRowByIndex(1);

            var vector2 = new Vector(array3);

            matrix3.SetVectorRowByIndex(1, vector2);

            vector2 = matrix3.GetVectorRowByIndex(1);

            Console.WriteLine(matrix1);

            Console.WriteLine(matrix2);

            Console.WriteLine(matrix3);
        }
    }
}
