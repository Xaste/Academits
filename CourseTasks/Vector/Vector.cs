using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        public double[] VectorDoubles { get; set; }

        public Vector(int n)
        {
            this.VectorDoubles = new double[n];
        }

        public Vector(Vector vect)
        {
            this.VectorDoubles = new double[vect.GetSize()];

            for (int i = 0; i < vect.GetSize(); i++)
            {
                this.VectorDoubles[i] = vect.VectorDoubles[i];
            }
        }

        public Vector(double[] array)
        {
            this.VectorDoubles = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                this.VectorDoubles[i] = array[i];
            }
        }

        public Vector(int n, double[] array)
        {
            this.VectorDoubles = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (i < array.Length)
                {
                    this.VectorDoubles[i] = array[i];

                }
                else
                {
                    this.VectorDoubles[i] = 0;
                }
            }
        }

        public int GetSize()
        {
            return VectorDoubles.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.GetSize() - 1; i++)
            {
                sb.Append($"{this.VectorDoubles[i]}, ");
            }
            sb.Append($"{this.VectorDoubles[this.GetSize() - 1]}");

            return sb.ToString();
        }
    }
}
