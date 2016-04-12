using System;

namespace Perwij.SingleCalculator
{
    public class Cosinus : ISingle
    {
        public double CreateCalculate(double one)
        {
        return Math.Cos(one);
        }
    }
}
