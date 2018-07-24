using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExercise
{
    public class Vector
    {
        private double[] vectorComponents;

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должена быть больше 0");
            }

            vectorComponents = new double[n];
        }

        public Vector(Vector vect)
        {
            vectorComponents = new double[vect.GetSize()];
            Array.Copy(vect.vectorComponents, vectorComponents, this.GetSize());
        }

        public Vector(double[] array)
        {
            if (array.Length <= 0)
            {
                throw new ArgumentException("Размерность вектора должена быть больше 0");
            }
            vectorComponents = new double[array.Length];

            Array.Copy(array, vectorComponents, array.Length);
        }

        public Vector(int n, double[] array)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должена быть больше 0");
            }

            this.vectorComponents = new double[n];

            Array.Copy(array, vectorComponents, Math.Min(array.Length, n));
        }

        public int GetSize()
        {
            return vectorComponents.Length;
        }

        public void SumVector(Vector vector)
        {
            Array.Resize(ref vectorComponents, Math.Max(this.GetSize(), vector.GetSize()));

            var minLength = Math.Min(vector.GetSize(), this.GetSize());
            for (int i = 0; i < minLength; i++)
            {
                vectorComponents[i] += vector.vectorComponents[i];
            }
        }

        public void SubVector(Vector vector)
        {
            Array.Resize(ref vectorComponents, Math.Max(this.GetSize(), vector.GetSize()));

            var minLength = Math.Min(vector.GetSize(), this.GetSize());
            for (int i = 0; i < minLength; i++)
            {
                vectorComponents[i] -= vector.vectorComponents[i];
            }
        }

        public void ScalarMultiplication(int scalar)
        {
            for (int i = 0; i < this.GetSize(); i++)
            {
                this.vectorComponents[i] *= scalar;
            }
        }

        public void TurnBackVector()
        {
            this.ScalarMultiplication(-1);
        }

        public double GetVectorLength()
        {
            double sum = 0;

            foreach (var item in vectorComponents)
            {
                sum += Math.Pow(item, 2);
            }

            return Math.Sqrt(sum);
        }

        public double GetVectorComponentByIndex(int n)
        {
            if (n < 0 || n >= vectorComponents.Length)
            {
                throw new ArgumentOutOfRangeException("Компонента с таким индексом не сущеествует");
            }

            return vectorComponents[n];
        }

        public void SetVectorComponentByIndex(int n, double value)
        {
            if (n < 0 || n >= vectorComponents.Length)
            {
                throw new ArgumentOutOfRangeException("Компонента с таким индексом не сущеествует");
            }

            this.vectorComponents[n] = value;
        }

        public static Vector SumVectors(Vector first, Vector second)
        {
            var vector = new Vector(first);
            vector.SumVector(second);

            return vector;
        }

        public static Vector SubtractionVectors(Vector first, Vector second)
        {
            var vector = new Vector(first);

            vector.SubVector(second);

            return vector;
        }

        public static double ScalarMultiply(Vector first, Vector second)
        {
            var count = Math.Min(first.GetSize(), second.GetSize());

            double result = 0;

            for (int i = 0; i < count; i++)
            {
                result += first.vectorComponents[i] * second.vectorComponents[i];
            }

            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("{ ");
            sb.Append(string.Join(", ", this.vectorComponents));
            sb.Append(" }");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, this))
            {
                return true;
            }

            if (ReferenceEquals(obj, null) || obj.GetType() != this.GetType())
            {
                return false;
            }

            var vector = (Vector)obj;

            if (vector.GetSize() != this.GetSize())
            {
                return false;
            }

            for (int i = 0; i < this.GetSize(); i++)
            {
                if (this.vectorComponents[i] != vector.vectorComponents[i])
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            const int prime = 7;
            var hash = 1;

            for (int i = 0; i < this.GetSize(); i++)
            {
                hash = hash * prime + vectorComponents[i].GetHashCode();
            }

            return hash;
        }
    }
}
