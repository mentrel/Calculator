using System;
using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CosinusTests
    {
        /// <summary>
        /// Функция тестирования нахождения косинуса введённого числа
        /// </summary>
        /// <param name="first"></param>
        /// <param name="expected"></param>
        [TestCase(0, 1)]
        public void CosinusTest(double first, double expected)
        {
            ISingle cosinusCalculator = new Cosinus();
            double result = cosinusCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }
    }
}
