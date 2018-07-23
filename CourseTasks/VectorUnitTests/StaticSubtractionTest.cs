using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorExercise;

namespace VectorUnitTests
{
    [TestClass]
    public class StaticSubstractionTest
    {
        [TestMethod]
        public void TestMethod2()
        {
            var array1 = new double[] { 17, 22, 33, 14, 5 };
            var array2 = new double[] { 1, 2, 3, 4, 5, 22, 22, 22, 22 };
            var array3 = new double[] { 1, 2, 3, 4, 5 };

            var vector1 = new Vector(array1);
            var vector2 = new Vector(array2);
            var vector3 = new Vector(array3);

            var arraySubAnswer1 = new double[] { 16, 20, 30, 10, 0, -22, -22, -22, -22 };
            var arraySubAnswer2 = new double[] { -16, -20, -30, -10, 0, 22, 22, 22, 22 };
            var arraySubAnswer3 = new double[] { 16, 20, 30, 10, 0 };
            var arraySubAnswer4 = new double[] { -16, -20, -30, -10, 0 };

            var vectorSubAnswer1 = new Vector(arraySubAnswer1);
            var vectorSubAnswer2 = new Vector(arraySubAnswer2);
            var vectorSubAnswer3 = new Vector(arraySubAnswer3);
            var vectorSubAnswer4 = new Vector(arraySubAnswer4);

            var vectorResult1 = Vector.SubtractionVectors(vector1, vector2);
            var vectorResult2 = Vector.SubtractionVectors(vector2, vector1);
            var vectorResult3 = Vector.SubtractionVectors(vector1, vector3);
            var vectorResult4 = Vector.SubtractionVectors(vector3, vector1);

            Assert.AreEqual(vectorResult1, vectorSubAnswer1);
            Assert.AreEqual(vectorResult2, vectorSubAnswer2);
            Assert.AreEqual(vectorResult3, vectorSubAnswer3);
            Assert.AreEqual(vectorResult4, vectorSubAnswer4);
        }
    }
}
