using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixExercise;

namespace MatrixTests
{
    [TestClass]
    public class DeterminantTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var array1 = new double[,] { { 0, 0, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 0, 3 }, { 0, 4, 0, 4 } };
            var matrix1 = new Matrix(array1);

            var determinantAnswer1 = -24;

            var determinantResult1 = matrix1.GetDeterminant();

            Assert.AreEqual(determinantAnswer1, determinantResult1);



            var array2 = new double[,] { { 2, -1, 4 }, { 1, 0.7, -5 }, { 0, 3, 0 } };
            var matrix2 = new Matrix(array2);

            var determinantAnswer2 = 42;

            var determinantResult2 = matrix2.GetDeterminant();

            Assert.AreEqual(determinantAnswer2, determinantResult2);
        }
    }
}
