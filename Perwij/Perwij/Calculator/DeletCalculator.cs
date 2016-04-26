using System;

namespace Perwij.Calculator
{
    public class DeletCalculator: ICalculator
    {
        /// <summary>
        /// Функция деления одного введённого числа на другое.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
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
