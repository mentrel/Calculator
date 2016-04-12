using System;
using Perwij.Calculator;

namespace Perwij
{
    public class Stepen : ICalculator
    {
        public double Calculate(double one, double two)
        {
            double result = Math.Pow(one, two);
            if (double.IsNaN(result))
            {
                if (one < 0 && two - Math.Floor(two) != 0)
                {
                    throw new Exception("Невозможно вычислить дробную степень отрицаьельного числа!!!");
                }
                
                throw new Exception("Не удалось возвести число " + one + " в степень " + two + "!");
            }
            return Math.Pow(one, two);
        }
    }
}
