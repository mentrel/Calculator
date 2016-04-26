using System;

namespace Perwij.SingleCalculator
{
    /// <summary>
    /// Функция нахождения синуса введённого числа
    /// </summary>
    public class Sinus : ISingle
    {
        public double CreateCalculate(double one)
        {
            return Math.Sin(one);
        }
            
    }
}
