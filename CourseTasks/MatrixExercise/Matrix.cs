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

        public Matrix(double[][] array)
        {
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
            var sb = new StringBuilder();
            sb.Append("{ ");
            foreach (var vector in Rows)
            {
                sb.Append("{ ");
                sb.Append(vector.GetSize());
                sb.Append(" }");
            }
            sb.Append(" }");

            return sb.ToString();
        }
    }
}
