namespace Perwij.Calculator
{
    public class MinusCalculator : ICalculator
    {
        /// <summary>
        /// Функция вычитания второго введённого числа из первого.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public double Calculate(double one, double two)
        {
            return one - two;
        }
    }
}
