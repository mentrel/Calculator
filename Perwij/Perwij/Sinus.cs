using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perwij
{
    public class Sinus : ISingle
    {
        public double CreateCalculator(double one)
        {
            return Math.Sin(one);
        }
            
    }
}
