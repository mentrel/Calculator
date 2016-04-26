namespace Perwij.Calculator
{
    public class SumCalculator : ICalculator
    {
        /// <summary>
        /// Функция суммирования двух введённых чисел.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public double Calculate(double one, double two)
        {
            return one + two;
        }
    }
}
