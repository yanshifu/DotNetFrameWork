using AspNetFrameWebApp.Models;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Sum(5, 6, 7);
            Assert.AreEqual(18, result);
        }
    }
}