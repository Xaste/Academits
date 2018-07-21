using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        public double[] VectorContent { get; set; }

        public Vector(int n)
        {
            this.VectorContent = new double[n];
        }

        public Vector(Vector vect)
        {
            this.VectorContent = new double[vect.GetSize()];

            for (var i = 0; i < vect.GetSize(); i++)
            {
                this.VectorContent[i] = vect.VectorContent[i];
            }
        }

        public Vector(double[] array)
        {
            this.VectorContent = new double[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                this.VectorContent[i] = array[i];
            }
        }

        public Vector(int n, double[] array)
        {
            this.VectorContent = new double[n];

            for (var i = 0; i < n; i++)
            {
                if (i < array.Length)
                {
                    this.VectorContent[i] = array[i];

                }
                else
                {
                    this.VectorContent[i] = 0;
                }
            }
        }

        public int GetSize()
        {
            return VectorContent.Length;
        }

        public Vector SumVector(Vector vector)
        {
            var maxVectorLength = Math.Max(this.GetSize(), vector.GetSize());

            var answerVector = new Vector(maxVectorLength);

            for (int i = 0; i < maxVectorLength; i++)
            {
                if (this.GetSize() - 1 < i)
                {
                    answerVector.VectorContent[i] = vector.VectorContent[i];
                }
                else if (vector.GetSize() - 1 <= i)
                {
                    answerVector.VectorContent[i] = this.VectorContent[i];
                }
                else
                {
                    answerVector.VectorContent[i] = VectorContent[i] + vector.VectorContent[i];
                }
            }

            return answerVector;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < this.GetSize() - 1; i++)
            {
                sb.Append($"{this.VectorContent[i]}, ");
            }
            sb.Append($"{this.VectorContent[this.GetSize() - 1]}");

            return sb.ToString();
        }

    }
}
