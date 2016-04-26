using System;
using System.Windows.Forms;
using Perwij.Calculator;
using Perwij.SingleCalculator;

namespace Perwij
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcued(object sender, EventArgs e)
        {
            try
            {
                string first = textBox1.Text;
                string two = textBox2.Text;
                double firstDouble = Convert.ToDouble(first);
                double twoDouble = Convert.ToDouble(two);
                ICalculator calculator = CalculatorFactory.Calculator(((Button) sender).Name);
                var result = calculator.Calculate(firstDouble, twoDouble);
                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        private void SingleCalcued(object sender, EventArgs e)
        {
            try
            {
                string first = textBox1.Text;
                double firstDouble = Convert.ToDouble(first);
                ISingle calculator = SingleCalculatorFactory.CreateCalculator(((Button) sender).Name);
                var result = calculator.CreateCalculate(firstDouble);
                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
