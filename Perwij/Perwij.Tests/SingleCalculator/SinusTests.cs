using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class SinusTests
    {
        /// <summary>
        /// Функция тестирования нахождения синуса из введённого числа.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(0, 0)]
        public void SinusTest(double first, double expected)
        {
            ISingle sinusCalculator = new Sinus();
            double result = sinusCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
