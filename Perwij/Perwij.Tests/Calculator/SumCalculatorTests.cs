using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class SumCalculatorTests
    {
        [TestCase(2,2,4)]
        [TestCase(2, 3, 5)]
        [TestCase(2, 4, 6)]
        [TestCase(2, 5, 7)]
        [TestCase(2, 6, 8)]
        [TestCase(2, 7, 9)]
        [TestCase(2, 8, 10)]
        public void SumTests(double first, double two, double expected)
        {
           ICalculator sumCalculator = new SumCalculator();
            double result = sumCalculator.Calculate(first, two);
            Assert.AreEqual(expected,result);
        }
    }
}
