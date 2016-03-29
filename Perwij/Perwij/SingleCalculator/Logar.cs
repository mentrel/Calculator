using System;

namespace Perwij.SingleCalculator
{
    public class Logar : ISingle
    {
        public double CreateCalculate(double one)
        {
            return Math.Log10(one);
        }
    }
}
