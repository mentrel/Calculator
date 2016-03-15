﻿using System;
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
            string first = textBox1.Text;
            string two = textBox2.Text;
            double firstDouble = Convert.ToDouble(first);
            double twoDouble = Convert.ToDouble(two);
            ICalculator calculator = CalculatorFactory.Calculator(((Button) sender).Name);
            var result = calculator.Calculator(firstDouble, twoDouble);
            textBox3.Text = result.ToString();
        }
        private void SingleCalcued(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            double firstDouble = Convert.ToDouble(first);
            ISingle calculator = SingleCalculatorFactory.CreateCalculator(((Button)sender).Name);
            var result = calculator.CreateCalculator(firstDouble);
            textBox3.Text = result.ToString();
        }
    }

   
}
