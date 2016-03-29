using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CosinusTests
    {
        [Test]
        public void CosinusTest()
        {
            ISingle cosinusCalculator = new Cosinus();
            double result = cosinusCalculator.CreateCalculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
