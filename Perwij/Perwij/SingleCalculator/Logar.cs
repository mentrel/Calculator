using System;

namespace Perwij.SingleCalculator
{
    public class Logar : ISingle
    {
        public double CreateCalculate(double one)
        {
            if (one < 0)
            {
                throw new ArgumentException("Насяльник, аргумент меньше нуля", "one");
            }
            return Math.Log10(one);
        }
    }
}
