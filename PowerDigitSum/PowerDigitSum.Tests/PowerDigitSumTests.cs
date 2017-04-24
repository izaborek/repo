using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerDigitSum;

namespace PowerDigitSum.Tests
{
    [TestClass]
    public class PowerDigitSumTests
    {
        [TestMethod]
        public void Power_Test()
        {
            var czy = new PowerDigitSum();
            double a = czy.power(2,2);
            Assert.AreEqual(a, 4);
        }
        [TestMethod]
        public void DigitSum_Test()
        {
            var czy = new PowerDigitSum();
            double a = czy.powerdigitsum(123);
            Assert.AreEqual(a, 6);
        }
    }
}
