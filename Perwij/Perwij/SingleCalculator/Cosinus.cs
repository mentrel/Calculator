using System;

namespace Perwij.SingleCalculator
{
    /// <summary>
    /// Функция нахождения косинуса введённого числа.
    /// </summary>
    public class Cosinus : ISingle
    {
        public double CreateCalculate(double one)
        {
        return Math.Cos(one);
        }
    }
}
