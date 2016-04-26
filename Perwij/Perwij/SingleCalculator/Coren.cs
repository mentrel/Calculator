using System;

namespace Perwij.SingleCalculator
{
    public class Coren : ISingle
    {
        /// <summary>
        /// Функция извлечения квадратного корня из введённого числа.
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        public double CreateCalculate(double one)
        {
            if (one < 0)
            {
                throw new ArgumentException("Насяльник, аргумент меньше нуля","one");
            }
            return Math.Sqrt(one);
        }
    }
}
