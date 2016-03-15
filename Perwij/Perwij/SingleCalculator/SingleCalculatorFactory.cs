using System;

namespace Perwij.SingleCalculator
{
    public static class SingleCalculatorFactory
    {
        public static ISingle CreateCalculator(String e)
        {
            switch (e)
            {
                case "sin":
                    return new Sinus();
                case "x2":
                    return new Cvadrat();
                case "Koren":
                    return new Coren();
                case "cos":
                    return new Cosinus();
                case "log":
                    return new Logar();
                default:
                    throw new ArgumentException("Неизвестная операция во имя Сатаны", "name");
            }

        }
    }
}
