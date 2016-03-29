using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CvadratTests
    {
        [Test]
        public void CvadratTest()
        {
            ISingle cvadratCalculator = new Cvadrat();
            double result = cvadratCalculator.CreateCalculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
