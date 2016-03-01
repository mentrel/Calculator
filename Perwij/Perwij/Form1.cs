using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string first = textBox1.Text;
            string two = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int twoInt = Convert.ToInt32(two);
            double result = 0;
            switch (((Button)sender).Name)
            {
                case  "+":
                    result = firstInt + twoInt;
                    break;
                case "-": 
                    result = firstInt - twoInt;
                    break;
                case "X": 
                    result = firstInt * twoInt;
                    break;
                case "/":
                    result = firstInt / twoInt;
                    break;
                   
            }
           
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
