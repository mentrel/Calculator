using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class SinusTests
    {
        [Test]
        public void SinusTest()
        {
            ISingle sinusCalculator = new Sinus();
            double result = sinusCalculator.CreateCalculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
