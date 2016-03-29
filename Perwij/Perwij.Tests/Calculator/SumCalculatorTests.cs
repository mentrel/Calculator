using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class SumCalculatorTests
    {
        [Test]
        public void SumTests()
        {
           ICalculator sumCalculator = new SumCalculator();
            double result = sumCalculator.Calculate(2, 2);
            Assert.AreEqual(4,result);
        }
    }
}
