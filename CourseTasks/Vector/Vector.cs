using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorExercise
{
    public class Vector
    {
        public double[] VectorComponents { get; set; }

        public Vector(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должена быть больше 0");
            }
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
            if (n <= 0)
            {
                throw new ArgumentException("Размерность вектора должена быть больше 0");
            }

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
                else if (vector.GetSize() - 1 < i)
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

        public void ScalarMultiplication(int scalar)
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

        public double GetVectorLength()
        {
            double sum = 0;

            for (int i = 0; i < this.GetSize(); i++)
            {
                sum += Math.Pow(VectorComponents[i], 2);
            }

            return Math.Sqrt(sum);
        }

        public double GetVectorComponentByIndex(int n)
        {
            if (n >= VectorComponents.Length)
            {
                throw new ArgumentException("Компонента с таким индексом не сущеествует");
            }

            return VectorComponents[n];
        }

        public void SetVectorCombonentByIndex(int n, double value)
        {
            if (n >= VectorComponents.Length)
            {
                throw new ArgumentException("Компонента с таким индексом не сущеествует");
            }

            this.VectorComponents[n] = value;
        }

        public static Vector SumVectors(Vector first, Vector second)
        {
            Vector longVector;
            Vector shortVector;

            if (first.GetSize() > second.GetSize())
            {
                longVector = first;
                shortVector = second;
            }
            else
            {
                longVector = second;
                shortVector = first;
            }

            var resultvVector = new Vector(longVector);

            for (int i = 0; i < shortVector.GetSize(); i++)
            {
                resultvVector.VectorComponents[i] += shortVector.VectorComponents[i];
            }

            return resultvVector;
        }

        public static Vector SubtractionVectors(Vector first, Vector second)
        {
            Vector longVector;
            Vector shortVector;

            if (first.GetSize() > second.GetSize())
            {
                longVector = new Vector(first);
                shortVector = new Vector(second);
                shortVector.TurnBackVector();
            }
            else
            {
                longVector = new Vector(second);
                longVector.TurnBackVector();

                shortVector = first;
            }

            var resultvVector = new Vector(longVector);

            for (int i = 0; i < shortVector.GetSize(); i++)
            {
                resultvVector.VectorComponents[i] += shortVector.VectorComponents[i];
            }

            return resultvVector;
        }

        public static double ScalarMultiply(Vector first, Vector second)
        {
            var count = (first.GetSize() < second.GetSize()) ? first.GetSize() : second.GetSize();

            var result = 0.0;

            for (int i = 0; i < count; i++)
            {
                result += first.VectorComponents[i] * second.VectorComponents[i];
            }

            return result;
        }

        public override string ToString()
        {
            return string.Join(", ", this.VectorComponents);

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
                if (this.VectorComponents[i] != vector.VectorComponents[i])
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
                hash = hash * prime + VectorComponents[i].GetHashCode();
            }

            return hash;
        }
    }
}
