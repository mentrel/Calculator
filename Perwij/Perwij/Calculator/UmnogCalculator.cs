namespace Perwij.Calculator
{
    public class UmnogCalculator : ICalculator
    {
        /// <summary>
        /// Функция умножения одного числа на другое
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns></returns>
        public double Calculate(double one, double two)
        {
            return one * two;
        }
    }
}
