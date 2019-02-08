using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TextWork.Model;

namespace TextWork.UnitTests
{
    [TestFixture]
    public class TextFormatterTests
    {
        readonly TextFormatter formatter = new TextFormatter();
        private static string _fileOutputPath = "D:\\MyRepos\\Academits\\WorkTestTasks\\1\\TextWork\\TextWorkTests\\TestTexts\\OutputText.txt";

        private Stream _fileOutputStream;
        private Stream _fileInputStream;
        private Stream _correctStream;


        [SetUp]
        public void Setup()
        {
            _fileOutputStream = File.Open(_fileOutputPath, FileMode.Create, FileAccess.ReadWrite);
        }

        [TearDown]
        public void TearDown()
        {
            _fileOutputStream?.Dispose();
            _fileInputStream?.Dispose();
            _correctStream?.Dispose();
        }

        [Test]
        public void SimpleTextKeepPunctuation()
        {
            formatter.MinWordLength = 3;
            var IsPuctuationDelete = false;

            var fileInputPath = "TestTexts\\SimpleText.txt";
            var correctFilePath = "TestTexts\\SimpleTextKeepPunctuationCorrect.txt";

            _fileInputStream = File.Open(fileInputPath, FileMode.Open, FileAccess.Read);
            _correctStream = File.Open(correctFilePath, FileMode.Open, FileAccess.Read);

            formatter.Convert(_fileInputStream, _fileOutputStream, IsPuctuationDelete);

            FileAssert.AreEqual(correctFilePath, _fileOutputPath);
        }
    }
}
