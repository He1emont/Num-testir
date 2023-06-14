using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberSystem;

namespace UnitTestNumberSystems
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 r = new Class1();
            Assert.AreEqual("10001001", r.CalculateNumberSystems(2, "137"));
            Assert.AreEqual("52", r.CalculateNumberSystems(8, "42"));
            Assert.AreEqual("F5", r.CalculateNumberSystems(16, "245"));
        }
    }
}
