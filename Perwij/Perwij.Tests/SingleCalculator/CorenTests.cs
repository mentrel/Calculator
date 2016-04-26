using System;
using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CorenTests
    {
        /// <summary>
        /// Функция тестирования функции извлечения корня из введённого числа
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(1, 1)]
        [TestCase(4, 2)]
        [TestCase(16, 4)]
        [TestCase(36, 6)]
        [TestCase(49, 7)]
        [TestCase(64, 8)]
        [TestCase(25, 5)]
        [TestCase(81, 9)]
        public void CorenTest(double first, double expected)
        {
            ISingle corenCalculator = new Coren();
            double result = corenCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }
        /// <summary>
        /// Функция проверки исключений
        /// </summary>
        [Test]
        public void CorenExceptionTest()
        {
            ISingle corenCalculator = new Coren();
            Assert.Throws<ArgumentException>(() => corenCalculator.CreateCalculate(-1));
        }
    }
}
