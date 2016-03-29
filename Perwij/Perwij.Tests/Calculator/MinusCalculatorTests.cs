using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class MinusCalculatorTests
    {
        [TestCase(2, 2, 0)]
        [TestCase(2, 0.5,1.5)]
        [TestCase(8, 2, 6)]
        [TestCase(7, 2, 5)]
        [TestCase(6, 2, 4)]
        [TestCase(4, 2, 2)]
        [TestCase(2, 1, 1)]
        public void MinusTests(double first, double two, double expected)
        {
            ICalculator minusCalculator = new MinusCalculator();
            double result = minusCalculator.Calculate(first, two);
            Assert.AreEqual(expected, result);
        }
    }
}
