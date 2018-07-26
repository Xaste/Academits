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

        public int RowsCount
        {
            get
            {
                return rows.Length;
            }
        }


        public Matrix(int rows, int columns)
        {
            this.rows = new Vector[rows];
            for (var i = 0; i < rows; i++)
            {
                this.rows[i] = new Vector(columns);
            }
        }

        public Matrix(Matrix matrix)
        {
            rows = new Vector[matrix.RowsCount];

            for (var i = 0; i < RowsCount; i++)
            {
                rows[i] = new Vector(matrix.rows[i]);
            }
        }

        public Matrix(double[][] array)
        {
            var maxLength = 0;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                maxLength = Math.Max(maxLength, array[i].Length);
            }

            rows = new Vector[array.GetLength(0)];

            for (var i = 0; i < RowsCount; i++)
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

            for (var i = 0; i < vectors.Length; i++)
            {
                rows[i] = new Vector(maxLength);
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
            if (n < 0 || n >= RowsCount)
            {
                throw new ArgumentException("В матрице те строки с указаным индексом");
            }

            return new Vector(rows[n]);
        }

        public void SetVectorRowByIndex(int n, Vector vector)
        {
            if (n < 0 || n >= RowsCount)
            {
                throw new ArgumentException("В матрице те строки с указаным индексом");
            }
            if (vector.GetSize() > ColumnCount)
            {
                throw new ArgumentException("Вектор больше размеров матрицы");
            }

            if (vector.GetSize() == ColumnCount)
            {
                rows[n] = new Vector(vector);
            }
            else
            {
                var tempVector = new Vector(vector);
                tempVector.SumVector(new Vector(ColumnCount));
                rows[n] = tempVector;
            }
        }

        public Vector GetVectorColumnByIndex(int n)
        {
            if (n < 0 || n >= ColumnCount)
            {
                throw new ArgumentException("В матрице нет столбца с указаным индексом");
            }

            var array = new double[RowsCount];

            for (var i = 0; i < RowsCount; i++)
            {
                array[i] = rows[i].GetVectorComponentByIndex(n);
            }

            return new Vector(array);
        }

        public void TransposeMatrix()
        {
            var matrix = new Matrix(this);

            Array.Resize(ref rows, matrix.ColumnCount);

            for (var i = 0; i < matrix.ColumnCount; i++)
            {
                this.rows[i] = matrix.GetVectorColumnByIndex(i);
            }
        }

        public void MultiplyByScalar(double scalar)
        {
            foreach (var vector in rows)
            {
                vector.ScalarMultiplication(scalar);
            }
        }

        public double GetDeterminant()
        {
            if (RowsCount != ColumnCount)
            {
                throw new InvalidOperationException("Для нахождения определителя матрица должна быть квадратна");
            }

            var matrix = new Matrix(this);

            var determinant = 1.0;

            const double epsilon = 1E-10;
            for (var i = 0; i < matrix.RowsCount - 1; i++)
            {
                if (Math.Abs(matrix.rows[i].GetVectorComponentByIndex(i)) < epsilon)
                {
                    var k = i;
                    while (Math.Abs(matrix.rows[k].GetVectorComponentByIndex(i)) < epsilon)
                    {
                        ++k;
                    }

                    var temp = matrix.rows[i];//Переставляем строку с ненулевым элементом на первую строку (меняем местами)
                    matrix.rows[i] = matrix.rows[k];
                    matrix.rows[k] = temp;
                    determinant *= -1;//С каждой перестановкой знак определителя меняется
                }

                determinant *= matrix.rows[i].GetVectorComponentByIndex(i);

                for (var j = i + 1; j < RowsCount; j++)
                {
                    if (Math.Abs(matrix.rows[j].GetVectorComponentByIndex(i)) < epsilon) continue;

                    var vector = new Vector(matrix.rows[i]);

                    vector.ScalarMultiplication(matrix.rows[j].GetVectorComponentByIndex(i) / matrix.rows[i].GetVectorComponentByIndex(i));
                    vector.TurnBackVector();

                    matrix.rows[j].SumVector(vector);
                }
            }

            return determinant;
        }

        public static Matrix MultiplyMatrixs(Matrix first, Matrix second)
        {
            if (first.ColumnCount != second.RowsCount)
            {
                throw new InvalidOperationException("Количество столбцов исходной матрицы должно быть равно количеству строк матрицы множителя.");
            }

            var answerMatrix = new Matrix(first.RowsCount, second.ColumnCount);

            for (var i = 0; i < answerMatrix.RowsCount; i++)
            {
                for (var j = 0; j < answerMatrix.ColumnCount; j++)
                {
                    var component = Vector.ScalarMultiply((first.GetVectorRowByIndex(i)), second.GetVectorColumnByIndex(j));

                    answerMatrix.rows[i].SetVectorComponentByIndex(j, component);
                }
            }

            return answerMatrix;
        }

        public Vector MultiplyByVector(Vector vector)
        {
            var answerVector = new Vector(this.RowsCount);

            for (var i = 0; i < answerVector.GetSize(); i++)
            {
                answerVector.SetVectorComponentByIndex(i, Vector.ScalarMultiply(this.rows[i], vector));
            }

            return answerVector;
        }

        public void AddMatrix(Matrix matrix)
        {
            if (this.RowsCount != matrix.RowsCount || this.ColumnCount != matrix.ColumnCount)
            {
                throw new InvalidOperationException("Матрицы должны быть одинаковой размерности!");
            }

            for (var i = 0; i < this.RowsCount; i++)
            {
                this.rows[i].SumVector(matrix.GetVectorRowByIndex(i));
                this.rows[i].SumVector(matrix.rows[i]);
            }
        }

        public static Matrix MatrixAddition(Matrix first, Matrix second)
        {
            var answerMatrix = new Matrix(first);
            answerMatrix.AddMatrix(second);

            return answerMatrix;
        }

        public void SubtractionMatrix(Matrix matrix)
        {
            if (this.RowsCount != matrix.RowsCount || this.ColumnCount != matrix.ColumnCount)
            {
                throw new InvalidOperationException("Матрицы должны быть одинаковой размерности!");
            }

            for (var i = 0; i < this.RowsCount; i++)
            {
                this.rows[i].SubVector(matrix.rows[i]);
            }
        }

        public static Matrix MatrixSubtraction(Matrix first, Matrix second)
        {
            var answerMatrix = new Matrix(first);
            answerMatrix.SubtractionMatrix(second);

            return answerMatrix;
        }

        public override string ToString()
        {
            var arrayStrings = new string[RowsCount];

            for (var i = 0; i < RowsCount; i++)
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
