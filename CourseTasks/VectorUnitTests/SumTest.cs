using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorExercise;

namespace VectorUnitTests
{
    [TestClass]
    public class SumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var array1 = new double[] { 17, 22, 33, 14, 5 };
            var array2 = new double[] { 1, 2, 3, 4, 5, 22, 22, 22, 22 };
            var array3 = new double[] { 1, 2, 3, 4, 5 };

            var vector1 = new Vector(array1);
            var vector2 = new Vector(array2);
            var vector3 = new Vector(array3);

            var arraySumAnswer1 = new double[] { 18, 24, 36, 18, 10, 22, 22, 22, 22 };
            var arraySumAnswer2 = new double[] { 18, 24, 36, 18, 10 };

            var vectorSumAnswer1 = new Vector(arraySumAnswer1);
            var vectorSumAnswer2 = new Vector(arraySumAnswer2);

            var vectorStaticResult1 = Vector.SumVectors(vector1, vector2);
            var vectorStaticResult2 = Vector.SumVectors(vector2, vector1);
            var vectorStaticResult3 = Vector.SumVectors(vector1, vector3);
            var vectorStaticResult4 = Vector.SumVectors(vector3, vector1);

            Assert.AreEqual(vectorStaticResult1, vectorSumAnswer1);
            Assert.AreEqual(vectorStaticResult2, vectorSumAnswer1);
            Assert.AreEqual(vectorStaticResult3, vectorSumAnswer2);

            var vectorNoStaticResult1 = vector1.SumVector(vector2);
            var vectorNoStaticResult2 = vector2.SumVector(vector1);
            var vectorNoStaticResult3 = vector1.SumVector(vector3);
            var vectorNoStaticResult4 = vector3.SumVector(vector1);

            Assert.AreEqual(vectorNoStaticResult1, vectorSumAnswer1);
            Assert.AreEqual(vectorNoStaticResult2, vectorSumAnswer1);
            Assert.AreEqual(vectorNoStaticResult3, vectorSumAnswer2);
            Assert.AreEqual(vectorNoStaticResult4, vectorSumAnswer2);
        }
    }
}
