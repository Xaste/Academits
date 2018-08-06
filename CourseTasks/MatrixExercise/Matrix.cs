using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorExercise;

namespace MatrixExercise
{
    public class Matrix
    {
        private Vector[] rows;

        public int ColumnsCount
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
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Число столбцов или колонок не может быть 0");
            }

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

        public Matrix(double[,] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Число столбцов или колонок не может быть 0");
            }

            rows = new Vector[array.GetLength(0)];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                var tempArray = new double[array.GetLength(1)];

                for (var j = 0; j < array.GetLength(1); j++)
                {
                    tempArray[j] = array[i, j];
                }

                rows[i] = new Vector(tempArray);
            }
        }

        public Matrix(Vector[] vectors)
        {
            if (vectors.Length == 0)
            {
                throw new ArgumentException("Число столбцов или колонок не может быть 0");
            }

            var maxLength = 0;

            foreach (var item in vectors)
            {
                maxLength = Math.Max(maxLength, item.GetSize());
            }

            if (maxLength == 0)
            {
                throw new ArgumentException("В массиве векторов нет ни одно вектора ненулевого размера");
            }

            rows = new Vector[vectors.Length];

            for (var i = 0; i < vectors.Length; i++)
            {
                rows[i] = new Vector(maxLength);
                rows[i].SumVector(vectors[i]);
            }
        }

        public Vector GetVectorRowByIndex(int n)
        {
            if (n < 0 || n >= RowsCount)
            {
                throw new ArgumentOutOfRangeException("В матрице нет строки с указаным индексом");
            }

            return new Vector(rows[n]);
        }

        public void SetVectorRowByIndex(int n, Vector vector)
        {
            if (n < 0 || n >= RowsCount)
            {
                throw new ArgumentOutOfRangeException("В матрице те строки с указаным индексом");
            }
            if (vector.GetSize() != ColumnsCount)
            {
                throw new ArgumentException("Вектор не соответствует размерам матрицы");
            }

            rows[n] = new Vector(vector);
        }

        public Vector GetVectorColumnByIndex(int n)
        {
            if (n < 0 || n >= ColumnsCount)
            {
                throw new ArgumentOutOfRangeException("В матрице нет столбца с указаным индексом");
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
            var columnArray = new Vector[ColumnsCount];

            for (var i = 0; i < ColumnsCount; i++)
            {
                columnArray[i] = this.GetVectorColumnByIndex(i);
            }

            rows = columnArray;
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
            if (RowsCount != ColumnsCount)
            {
                throw new InvalidOperationException("Для нахождения определителя матрица должна быть квадратна");
            }

            var matrix = new Matrix(this);

            var determinant = 1.0;

            const double epsilon = 1E-10;
            for (var i = 0; i < matrix.RowsCount; i++)
            {
                if (Math.Abs(matrix.rows[i].GetVectorComponentByIndex(i)) < epsilon)
                {
                    var k = i;
                    while (Math.Abs(matrix.rows[k].GetVectorComponentByIndex(i)) < epsilon)//TODO Если все нули нужно продумать!!!!
                    {
                        ++k;

                        if (k == matrix.RowsCount)
                        {
                            return 0;
                        }
                    }

                    var temp = matrix.rows[i];//Переставляем строку с ненулевым элементом на первую строку (меняем местами)
                    matrix.rows[i] = matrix.rows[k];
                    matrix.rows[k] = temp;
                    determinant *= -1;//С каждой перестановкой знак определителя меняется
                }

                determinant *= matrix.rows[i].GetVectorComponentByIndex(i);

                for (var j = i + 1; j < RowsCount; j++)
                {
                    if (Math.Abs(matrix.rows[j].GetVectorComponentByIndex(i)) < epsilon)
                    {
                        continue;
                    }

                    var vector = new Vector(matrix.rows[i]);

                    vector.ScalarMultiplication(matrix.rows[j].GetVectorComponentByIndex(i) / matrix.rows[i].GetVectorComponentByIndex(i));
                    vector.TurnBackVector();

                    matrix.rows[j].SumVector(vector);
                }
            }

            return determinant;
        }

        public static Matrix MultiplyMatrixes(Matrix first, Matrix second)
        {
            if (first.ColumnsCount != second.RowsCount)
            {
                throw new InvalidOperationException("Количество столбцов исходной матрицы должно быть равно количеству строк матрицы множителя.");
            }

            var answerMatrix = new Matrix(first.RowsCount, second.ColumnsCount);

            for (var i = 0; i < answerMatrix.RowsCount; i++)
            {
                for (var j = 0; j < answerMatrix.ColumnsCount; j++)
                {
                    var component = Vector.ScalarMultiply(first.rows[i], second.GetVectorColumnByIndex(j));

                    answerMatrix.rows[i].SetVectorComponentByIndex(j, component);
                }
            }

            return answerMatrix;
        }

        public Vector MultiplyByVector(Vector vector)
        {
            if (vector.GetSize() != this.ColumnsCount)
            {
                throw new ArgumentException("Вектор не соответствует размерности матрицы");
            }

            var answerVector = new Vector(this.RowsCount);

            for (var i = 0; i < answerVector.GetSize(); i++)
            {
                answerVector.SetVectorComponentByIndex(i, Vector.ScalarMultiply(this.rows[i], vector));
            }

            return answerVector;
        }

        public void AddMatrix(Matrix matrix)
        {
            if (this.RowsCount != matrix.RowsCount || this.ColumnsCount != matrix.ColumnsCount)
            {
                throw new InvalidOperationException("Матрицы должны быть одинаковой размерности!");
            }

            for (var i = 0; i < this.RowsCount; i++)
            {
                this.rows[i].SumVector(matrix.rows[i]);
            }
        }

        public static Matrix MatrixAddition(Matrix first, Matrix second)
        {
            if (first.RowsCount != second.RowsCount || first.ColumnsCount != second.ColumnsCount)
            {
                throw new InvalidOperationException("Матрицы должны быть одинаковой размерности!");
            }

            var answerMatrix = new Matrix(first);
            answerMatrix.AddMatrix(second);

            return answerMatrix;
        }

        public void SubtractionMatrix(Matrix matrix)
        {
            if (this.RowsCount != matrix.RowsCount || this.ColumnsCount != matrix.ColumnsCount)
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
            if (first.RowsCount != second.RowsCount || first.ColumnsCount != second.ColumnsCount)
            {
                throw new InvalidOperationException("Матрицы должны быть одинаковой размерности!");
            }

            var answerMatrix = new Matrix(first);
            answerMatrix.SubtractionMatrix(second);

            return answerMatrix;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("{ ");

            for (var i = 0; i < RowsCount - 1; i++)
            {
                sb.Append(rows[i].ToString());
                sb.Append(", ");
            }

            sb.Append(rows[RowsCount - 1]).ToString();
            sb.Append(" }");

            return sb.ToString();
        }
    }
}
