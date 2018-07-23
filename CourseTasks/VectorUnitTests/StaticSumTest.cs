using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorExercise;

namespace VectorUnitTests
{
    [TestClass]
    public class StaticSumTest
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

            var vectorResult1 = Vector.SumVectors(vector1, vector2);
            var vectorResult2 = Vector.SumVectors(vector2, vector1);
            var vectorResult3 = Vector.SumVectors(vector1, vector3);

            Assert.AreEqual(vectorResult1, vectorSumAnswer1);
            Assert.AreEqual(vectorResult2, vectorSumAnswer1);
            Assert.AreEqual(vectorResult3, vectorSumAnswer2);
        }
    }
}
