using System;

namespace Perwij.SingleCalculator
{
    public class Sinus : ISingle
    {
        public double CreateCalculator(double one)
        {
            return Math.Sin(one);
        }
            
    }
}
