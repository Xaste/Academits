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

        public int ColumnCount
        {
            get
            {
                return rows[0].GetSize();
            }
        }

        public Matrix(int rows, int columns)
        {
            this.rows = new Vector[rows];
            for (int i = 0; i < rows; i++)
            {
                this.rows[i] = new Vector(columns);
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
            var maxLength = 0;
            for (int i = 0; i < array.GetLength(0); i++)//TODO Подумать, может можно сделать лучше
            {
                maxLength = Math.Max(maxLength, array[i].Length);
            }

            rows = new Vector[array.GetLength(0)];

            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new Vector(maxLength, array[i]);
            }
        }

        public Matrix(Vector[] vectors)
        {
            var maxLength = 0;

            foreach (var item in vectors)
            {
                maxLength = Math.Max(maxLength, item.GetSize());
            }
            rows = new Vector[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                rows[i] = new Vector(maxLength);//TODO Можно через статическиую одной операцией, но стоит ли?
                rows[i].SumVector(vectors[i]);
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

        public Vector GetVectorColumnByIndex(int n)//TODO Need to check!!!
        {
            var array = new double[rows.Length];

            for (int i = 0; i < rows.Length; i++)
            {
                array[i] = rows[i].GetVectorComponentByIndex(n);
            }
            return new Vector(array);
        }

        public void TransposeMatrix()
        {
            //var ColumnArray = new Vector[MatrixLength];
            var matrix = new Matrix(this);

            Array.Resize(ref rows, matrix.ColumnCount);

            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                this.rows[i] = matrix.GetVectorColumnByIndex(i);
            }
        }

        public void MultiplyByScalar(int scalar)
        {
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i].ScalarMultiplication(scalar);
            }
        }

        public double GetDeterminant()
        {
            if (rows.Length != this.ColumnCount)
            {
                throw new InvalidOperationException("Для нахождения определителя матрица должна быть квадратна");
            }

            Matrix matrix = new Matrix(this);

            var determinant = 1.0;
            for (int i = 0; i < matrix.rows.Length - 1; i++)
            {
                if (matrix.rows[i].GetVectorComponentByIndex(i) == 0)
                {
                    var k = i;
                    while (matrix.rows[k].GetVectorComponentByIndex(i) == 0)
                    {
                        ++k;
                    }

                    var temp = matrix.rows[i];//Переставляем строку с ненулевым элементом на первую строку (меняем местами)
                    matrix.rows[i] = matrix.rows[k];
                    matrix.rows[k] = temp;
                    determinant *= -1;
                }

                determinant *= matrix.rows[i].GetVectorComponentByIndex(i);

                for (int j = i + 1; j < rows.Length; j++)
                {
                    if (matrix.rows[j].GetVectorComponentByIndex(i) != 0)
                    {
                        Vector vector = new Vector(matrix.rows[i]);//неудобно что вектор сам меняется, приходится создавать новый для умножения на скаляр

                        vector.ScalarMultiplication(matrix.rows[j].GetVectorComponentByIndex(i) / matrix.rows[i].GetVectorComponentByIndex(i));
                        vector.TurnBackVector();

                        matrix.rows[j].SumVector(vector);
                    }
                }
            }

            return determinant;
        }

        public Matrix MultiplyMatrix(Matrix matrix)//TODO Доделать!
        {
            if (this.ColumnCount != matrix.rows.Length)
            {
                throw new InvalidOperationException("Количество столбцов исходной матрицы должно быть равно количеству строк матрицы множителя.");
            }

            Matrix answerMatrix = new Matrix(this.rows.Length, matrix.ColumnCount);

            for (int i = 0; i < matrix.ColumnCount; i++)
            {
                var component = 0.0;

                for (int j = 0; j < matrix.ColumnCount; j++)//вообще не то
                {
                    component += this.rows[i].GetVectorComponentByIndex(j) * matrix.rows[j].GetVectorComponentByIndex(i);

                    answerMatrix.rows[i].SetVectorComponentByIndex(j, component);//Кажется нужно делать через сложение векторов
                }
            }

            return answerMatrix;
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
