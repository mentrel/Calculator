using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class DeletCalculatorTests
    {
        [Test]
        public void DeleteTests()
        {
            ICalculator delet = new DeletCalculator();
            double result = delet.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}
