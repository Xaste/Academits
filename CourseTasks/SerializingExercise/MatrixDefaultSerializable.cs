using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializingExercise
{
    [Serializable]
    class MatrixDefaultSerializable
    {
        private int[][] matrixData;

        public MatrixDefaultSerializable(int size)
        {
            matrixData = new int[size][];
            for (int i = 0; i < matrixData.GetLength(0); i++)
            {
                matrixData[i] = new int[size];
            }
        }

        public MatrixDefaultSerializable(int[][] matrix)
        {
            matrixData = matrix;
        }

        public void FillMatrix(int[][] matrix)
        {
            matrixData = matrix;
        }
    }
}
