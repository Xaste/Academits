using NUnit.Framework;
using TextWork.Model;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var c = new TextFormatter();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}