using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perwij.SingleCalculator
{
    public class Cosinus : ISingle
    {
        public double CreateCalculator(double one)
        {
            return Math.Cos(one);
        }
    }
}
