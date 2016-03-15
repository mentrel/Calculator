using System;

namespace Perwij.Calculator
{
    public static class CalculatorFactory
    {
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
                default: 
                    throw new ArgumentException("Неизвестная операция во имя Сатаны","name");
            }
          
        }
    }
}
