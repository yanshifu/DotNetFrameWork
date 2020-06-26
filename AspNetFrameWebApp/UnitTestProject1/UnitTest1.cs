using System;
using AspNetFrameWebApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calculator = new Calculator();
            var result = calculator.Sum(4, 5, 6);
            Assert.AreEqual<int>(15, result);
        }
    }
}
