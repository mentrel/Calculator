using System;

namespace Perwij.SingleCalculator
{
    public class Sinus : ISingle
    {
        public double CreateCalculate(double one)
        {
            return Math.Sin(one);
        }
            
    }
}
