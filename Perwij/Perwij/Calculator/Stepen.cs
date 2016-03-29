using System;
using Perwij.Calculator;

namespace Perwij
{
    public class Stepen : ICalculator
    {
        public double Calculate(double one, double two)
        {
            return Math.Pow(one, two);
        }
    }
}
