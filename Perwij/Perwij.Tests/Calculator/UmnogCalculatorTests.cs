using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class UmnogCalculatorTests
    {
        [Test]
        public void UmnogTests()
        {
            ICalculator umnogCalculator = new UmnogCalculator();
            double result = umnogCalculator.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}
