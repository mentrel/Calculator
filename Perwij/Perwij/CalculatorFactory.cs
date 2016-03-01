using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perwij
{
    class CalculatorFactory
    {
        public ICalculator Calculator(String e)
        {
            ICalculator calc;
            switch (e)
            {
                case "summ":
                    calc = new SumCalculator();
                    
                    break;
                case "minus":
                    calc = new MinusCalculator();
                    break;
                case "X":
                    calc = new UmnogCalculator();
                    break;
                case "delet":
                    calc = new DeletCalculator();
                    break;
                default: throw new ArgumentException("Неизвестная операция во имя Сатаны","name");
            }
            return calc;
        }
    }
}
