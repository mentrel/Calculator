using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perwij.Calculator;

namespace Perwij
{
    public class Stepen : ICalculator
    {
        public double Calculator(double one, double two)
        {
            return Math.Pow(one, two);
        }
    }
}
