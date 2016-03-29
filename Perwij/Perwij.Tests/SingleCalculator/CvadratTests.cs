using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CvadratTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        [TestCase(4, 16)]
        [TestCase(6, 36)]
        [TestCase(5, 25)]
        [TestCase(7, 49)]
        [TestCase(8, 64)]
        [TestCase(9, 81)]
        public void CvadratTest(double first, double expected)
        {
            ISingle cvadratCalculator = new Cvadrat();
            double result = cvadratCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
