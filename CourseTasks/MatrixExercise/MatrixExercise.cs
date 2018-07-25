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

            var array1 = new double[][] { new double[] { 1, 2, 3 }, new double[] { 0, 2, 3, 4 }, new double[] { 1, 2 }, new double[] { 1, 2, 3, 4, 5, 6 } };
            var array2 = new double[] { 17, 22, 33, 14, 5 };
            var array3 = new double[] { 1, 2, 3, 4 };
            var array4 = new double[][] { new double[] { 0, 0, 1, 1 }, new double[] { 2, 2, 2, 2 }, new double[] { 3, 3, 0, 3 }, new double[] { 0, 4, 0, 4 } };

            var matrix2 = new Matrix(array1);

            var matrix3 = new Matrix(matrix2);

            var vectorColumn = matrix3.GetVectorColumnByIndex(1);

            var vectorArray = new Vector[] { new Vector(8), new Vector(array2) };

            var matrix4 = new Matrix(vectorArray);

            var a = matrix3.ColumnCount;
            matrix3.TransposeMatrix();

            matrix3.MultiplyByScalar(5);

            var vector = matrix3.GetVectorRowByIndex(1);

            var vector2 = new Vector(array3);

            matrix3.SetVectorRowByIndex(1, vector2);

            vector2 = matrix3.GetVectorRowByIndex(1);

            var matrix5 = new Matrix(array4);

            var determinant = matrix5.GetDeterminant();

            var array5 = new double[][] { new double[] { 2, 1, 3 }, new double[] { 6, 4, 5 } };

            var array6 = new double[][] { new double[] { 3, 1 }, new double[] { 1, 2 }, new double[] { 5, 3 } };

            var matrix6 = new Matrix(array5);
            var matrix7 = new Matrix(array6);

            var matrix8 = Matrix.MultiplyByMatrix(matrix6, matrix7);

            var array7 = new double[][] { new double[] { 2, 4, 0 }, new double[] { -2, 1, 3 }, new double[] { -1, 0, 1 } };
            var array8 = new double[] { 1, 2, -1};

            var matrix9 = new Matrix(array7);
            var vector3 = new Vector(array8);

            var vector4 = matrix9.MultiplyByVector(vector3);

            Console.WriteLine(matrix1);

            Console.WriteLine(matrix2);

            Console.WriteLine(matrix3);
        }
    }
}
