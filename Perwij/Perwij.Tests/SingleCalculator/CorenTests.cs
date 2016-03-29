using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CorenTests
    {
        [Test]
        public void CorenTest()
        {
            ISingle corenCalculator = new Coren();
            double result = corenCalculator.CreateCalculate(4);
            Assert.AreEqual(2, result);
        }
    }
}
