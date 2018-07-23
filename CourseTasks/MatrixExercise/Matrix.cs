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
    }
}
