using System;
using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class LogarTests
    {
        [TestCase(1, 0)]
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        [TestCase(10000, 4)]
        [TestCase(100000, 5)]
        [TestCase(1000000, 6)]
        public void LogarTest(double first, double expected)
        {
            ISingle logarCalculator = new Logar();
            double result = logarCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void LogarExceptionTest()
        {
            ISingle logarCalculator = new Logar();
            Assert.Throws<ArgumentException>(() => logarCalculator.CreateCalculate(-1));
        }
    }
}
