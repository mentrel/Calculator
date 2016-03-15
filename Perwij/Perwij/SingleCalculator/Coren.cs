using System;

namespace Perwij.SingleCalculator
{
    public class Coren : ISingle
    {
        public double CreateCalculator(double one)
        {
            return Math.Sqrt(one);
        }
    }
}
