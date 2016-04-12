using System;

namespace Perwij.Calculator
{
    public class DeletCalculator: ICalculator
    {
        public double Calculate(double one, double two)
        {
            if (two == 0)
            {
               throw new ArgumentException("Знаменатель равен нулю","two");
            }
            return one / two;
        }
    }
}
