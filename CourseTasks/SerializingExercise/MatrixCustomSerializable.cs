using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SerializingExercise
{
    [Serializable]
    class MatrixCustomSerializable : ISerializable
    {
        [NonSerialized]
        private int[][] matrixData;

        public MatrixCustomSerializable(int size)
        {
            matrixData = new int[size][];
            for (int i = 0; i < matrixData.GetLength(0); i++)
            {
                matrixData[i] = new int[size];
            }
        }

        public MatrixCustomSerializable(int[][] matrix)
        {
            matrixData = matrix;
        }

        protected MatrixCustomSerializable(SerializationInfo info, StreamingContext context)
        {
            //var matrixLength = info.GetValue("matrixLength", typeof(int));

        }

        public void FillMatrix(int[][] matrix)
        {
            matrixData = matrix;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //info.AddValue("matrixLength", matrixData.GetLength(0));
            /*for (int i = 0; i < matrixData.GetLength(0); i++)
            {
                LinkedList<double> row = new LinkedList<double>();

                for (int j = i; j < matrixData.GetLength(1); j++)
                {
                    row.AddLast(matrixData[i,j]);
                }

                info.AddValue($"row {i}", row);
            }*/

            for (int i = 0; i < matrixData.GetLength(0); i++)
            {
                int[] x = new int[matrixData.GetLength(0) - i];

                for (int j = 0; j < x.Length; j++)
                {
                    x[j] = matrixData[i][i + j];
                }

                info.AddValue($"row {i}", x);
            }
        }
    }
}
