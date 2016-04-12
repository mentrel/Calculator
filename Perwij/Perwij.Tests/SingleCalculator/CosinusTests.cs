using System;
using NUnit.Framework;
using Perwij.SingleCalculator;

namespace Perwij.Tests.SingleCalculator
{
    [TestFixture]
    public class CosinusTests
    {
        [TestCase(0, 1)]
        public void CosinusTest(double first, double expected)
        {
            ISingle cosinusCalculator = new Cosinus();
            double result = cosinusCalculator.CreateCalculate(first);
            Assert.AreEqual(expected, result);
        }

       
    }
}
