using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixExercise
{
    class MatrixExercise
    {
        static void Main(string[] args)
        {
            var matrix1 = new Matrix(5, 4);

            var array1 = new double[][] { new double[] { 1, 2, 3 }, new double[] { 2, 3, 4 }, new double[] { 1, 2 }, new double[] { 1 } };

            var matrix2 = new Matrix(array1);

            var matrix3 = new Matrix(matrix2);

            Console.WriteLine(matrix1);

            Console.WriteLine(matrix2);

            Console.WriteLine(matrix3);
        }
    }
}
