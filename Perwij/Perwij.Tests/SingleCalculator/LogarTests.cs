using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class LogarTests
    {
        [Test]
        public void LogarTest()
        {
            ISingle logarCalculator = new Logar();
            double result = logarCalculator.CreateCalculate(100);
            Assert.AreEqual(2, result);
        }
    }
}
