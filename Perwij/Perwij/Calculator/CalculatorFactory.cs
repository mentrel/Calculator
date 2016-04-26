using System;

namespace Perwij.Calculator
{
    /// <summary>
    /// Фабрика для функций, выполняющих действия над двумя аргументами.
    /// </summary>
    public static class CalculatorFactory
    {
        /// <summary>
        /// Функция реализации функций калькулятора.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static ICalculator Calculator(String e)
        {
            switch (e)
            {
                case "summ":
                    return new SumCalculator();
                case "minus":
                    return new MinusCalculator();
                case "X":
                    return new UmnogCalculator();
                case "delet":
                    return new DeletCalculator();
                case "stepen":
                    return new Stepen();
                default: 
                    throw new ArgumentException("Неизвестная операция во имя Сатаны","name");
            }
          
        }
    }
}
