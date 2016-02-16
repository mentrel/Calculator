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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           string first = textBox1.Text;
           string two = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int twoInt = Convert.ToInt32(two);
            double result = firstInt + twoInt;
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string two = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int twoInt = Convert.ToInt32(two);
            double result = firstInt * twoInt;
            textBox3.Text = result.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string two = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int twoInt = Convert.ToInt32(two);
            double result = firstInt - twoInt;
            textBox3.Text = result.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string two = textBox2.Text;
            int firstInt = Convert.ToInt32(first);
            int twoInt = Convert.ToInt32(two);
            double result = firstInt / twoInt;
            textBox3.Text = result.ToString();
        }
    }
}
