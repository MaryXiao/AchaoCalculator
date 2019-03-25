
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;


namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a=10;int b = 10;int c = 10;
            int expected =10;
            int actual;
            actual = a/b*c;
            Assert.AreEqual(expected, actual);
        }
    }
}
