using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perwij.SingleCalculator
{
    public class Logar : ISingle
    {
        public double CreateCalculator(double one)
        {
            return Math.Log10(one);
        }
    }
}
