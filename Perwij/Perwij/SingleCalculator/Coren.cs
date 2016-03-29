using System;

namespace Perwij.SingleCalculator
{
    public class Coren : ISingle
    {
        public double CreateCalculate(double one)
        {
            return Math.Sqrt(one);
        }
    }
}
