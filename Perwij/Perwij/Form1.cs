using System;
using System.Windows.Forms;

namespace Perwij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Calcued(object sender, EventArgs e)
        {
            CalculatorFactory sFactory = new CalculatorFactory();
            string first = textBox1.Text;
            string two = textBox2.Text;
            double firstDouble = Convert.ToDouble(first);
            double twoDouble = Convert.ToDouble(two);
            double result = 0;
            ICalculator calculator = sFactory.Calculator(((Button) sender).Name);
            result = calculator.Calculator(firstDouble, twoDouble);
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
