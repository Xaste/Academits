using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorExercise;

namespace MatrixExercise
{
    class Matrix
    {
        public Vector[] Rows { get; set; }

        public Matrix(int n, int m)
        {
            Rows = new Vector[n];
            for (int i = 0; i < n; i++)
            {
                Rows[i] = new Vector(m);
            }
        }

        public Matrix(Matrix matrix)
        {
            Rows = new Vector[matrix.Rows.Length];

            for (int i = 0; i < Rows.Length; i++)
            {
                Rows[i] = new Vector(matrix.Rows[i].GetSize());

                for (int j = 0; j < matrix.Rows[i].GetSize(); j++)
                {
                    Rows[i].VectorComponents[j] = matrix.Rows[i].VectorComponents[j];
                }
            }
        }

        public Matrix(double[][] array)
        {
            Rows = new Vector[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Rows[i] = new Vector(array[i]);
            }
        }

        public Matrix(Vector[] vectors)
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                Rows[i] = new Vector(vectors[i]);
            }
        }

        public int GetSize()
        {
            var count = 0;
            foreach (var vector in Rows)
            {
                count += vector.GetSize();
            }

            return count;
        }

        public override string ToString()
        {
            var arrayStrings = new string[Rows.Length];

            for (int i = 0; i < Rows.Length; i++)
            {
                arrayStrings[i] = Rows[i].ToString();
            }

            var sb = new StringBuilder();
            sb.Append("{{ ");
            sb.Append(string.Join(" }, { ", arrayStrings));
            sb.Append(" }}");
            return sb.ToString();
        }
    }
}
