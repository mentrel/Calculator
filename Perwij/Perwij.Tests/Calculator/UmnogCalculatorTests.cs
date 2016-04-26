using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class UmnogCalculatorTests
    {
        /// <summary>
        /// Функция тестирования умножения двух введённых чисел
        /// </summary>
        /// <param name="first"></param>
        /// <param name="two"></param>
        /// <param name="expected"></param>
        [TestCase(2, 2, 4)]
        [TestCase(2, 0.5,1)]
        [TestCase(8, 2, 16)]
        [TestCase(7, 2, 14)]
        [TestCase(6, 2, 12)]
        [TestCase(4, 2, 8)]
        [TestCase(2, 2, 4)]
        [TestCase(2, 1, 2)]
        public void UmnogTests(double first, double two, double expected)
        {
            ICalculator umnogCalculator = new UmnogCalculator();
            double result = umnogCalculator.Calculate(first, two);
            Assert.AreEqual(expected, result);
        }
    }
}
