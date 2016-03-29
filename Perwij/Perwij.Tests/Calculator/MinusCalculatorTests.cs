using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class MinusCalculatorTests
    {
        [Test]
        public void MinusTests()
        {
            ICalculator minusCalculator = new MinusCalculator();
            double result = minusCalculator.Calculate(2, 2);
            Assert.AreEqual(0, result);
        }
    }
}
