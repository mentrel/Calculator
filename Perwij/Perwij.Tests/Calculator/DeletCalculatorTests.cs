using System;
using NUnit.Framework;
using Perwij.Calculator;

namespace Perwij.Tests.Calculator
{
    [TestFixture]
    public class DeletCalculatorTests
    {
        /// <summary>
        /// Функция тестирования деления одного введённого числа на другое.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="two"></param>
        /// <param name="expected"></param>
        [TestCase(2,2,1)]
        [TestCase(2, 0.5, 4)]
        [TestCase(8, 2, 4)]
        [TestCase(6, 2, 3)]
        [TestCase(4, 2, 2)]
        [TestCase(2, 1, 2)]
        public void DeleteTests(double first, double two, double expected)
        {
            ICalculator delet = new DeletCalculator();
            double result = delet.Calculate(first, two);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Функция нахождения исключений.
        /// </summary>
        [Test]
        public void DeletExceptionTest()
        {
            ICalculator delet = new DeletCalculator();
            Assert.Throws<ArgumentException>(() => delet.Calculate(2, 0));
        }
    }
}
