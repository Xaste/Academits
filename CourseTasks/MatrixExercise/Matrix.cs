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
        private Vector[] rows;

        public Matrix(int n, int m)
        {
            rows = new Vector[n];
            for (int i = 0; i < n; i++)
            {
                rows[i] = new Vector(m);
            }
        }

        public Matrix(Matrix matrix)
        {
            rows = new Vector[matrix.rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new Vector(matrix.rows[i]);
            }
        }

        public Matrix(double[][] array)
        {
            rows = new Vector[array.GetLength(0)];

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new Vector(array[i]);
            }
        }

        public Matrix(Vector[] vectors)
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                rows[i] = new Vector(vectors[i]);
            }
        }

        public int GetSize()
        {
            var count = 0;
            foreach (var vector in rows)
            {
                count += vector.GetSize();
            }

            return count;
        }

        public Vector GetVectorRowByIndex(int n)
        {
            return new Vector(rows[n]);
        }

        public void SetVectorRowByIndex(int n, Vector vector)
        {
            rows[n] = new Vector(vector);
        }

        public Vector GetVectorColumnByIndex(int n)//TODO НЕ ДОДЕЛАНО!!!
        {
            return new Vector(1);
        }

        public override string ToString()
        {
            var arrayStrings = new string[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                arrayStrings[i] = rows[i].ToString();
            }

            var sb = new StringBuilder();
            sb.Append("{ ");
            sb.Append(string.Join(", ", arrayStrings));
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
