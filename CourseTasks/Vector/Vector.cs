using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Vector
    {
        public double[] VectorComponents { get; set; }

        public Vector(int n)
        {
            this.VectorComponents = new double[n];
        }

        public Vector(Vector vect)
        {
            this.VectorComponents = new double[vect.GetSize()];

            for (var i = 0; i < vect.GetSize(); i++)
            {
                this.VectorComponents[i] = vect.VectorComponents[i];
            }
        }

        public Vector(double[] array)
        {
            this.VectorComponents = new double[array.Length];
            for (var i = 0; i < array.Length; i++)
            {
                this.VectorComponents[i] = array[i];
            }
        }

        public Vector(int n, double[] array)
        {
            this.VectorComponents = new double[n];

            for (var i = 0; i < n; i++)
            {
                if (i < array.Length)
                {
                    this.VectorComponents[i] = array[i];

                }
                else
                {
                    this.VectorComponents[i] = 0;
                }
            }
        }

        public int GetSize()
        {
            return VectorComponents.Length;
        }

        public Vector SumVector(Vector vector)
        {
            var maxVectorLength = Math.Max(this.GetSize(), vector.GetSize());

            var answerVector = new Vector(maxVectorLength);

            for (int i = 0; i < maxVectorLength; i++)
            {
                if (this.GetSize() - 1 < i)
                {
                    answerVector.VectorComponents[i] = vector.VectorComponents[i];
                }
                else if (vector.GetSize() - 1 <= i)
                {
                    answerVector.VectorComponents[i] = this.VectorComponents[i];
                }
                else
                {
                    answerVector.VectorComponents[i] = VectorComponents[i] + vector.VectorComponents[i];
                }
            }

            return answerVector;
        }

        public Vector SubVector(Vector vector)
        {
            var maxVectorLength = Math.Max(this.GetSize(), vector.GetSize());
            var firsVector = new Vector(maxVectorLength, this.VectorComponents);
            var secondVector = new Vector(maxVectorLength, vector.VectorComponents);

            var answerVector = new Vector(maxVectorLength);

            for (int i = 0; i < maxVectorLength; i++)
            {
                answerVector.VectorComponents[i] = firsVector.VectorComponents[i] - secondVector.VectorComponents[i];
            }

            return answerVector;
        }

        public void ScalarMultiplication(int scalar)//TODO Здесь сделал с void. Надо спросить как лучше
        {
            for (int i = 0; i < this.GetSize(); i++)
            {
                this.VectorComponents[i] *= scalar;
            }
        }

        public void TurnBackVector()
        {
            this.ScalarMultiplication(-1);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (var i = 0; i < this.GetSize() - 1; i++)
            {
                sb.Append($"{this.VectorComponents[i]}, ");
            }
            sb.Append($"{this.VectorComponents[this.GetSize() - 1]}");

            return sb.ToString();
        }

    }
}
