using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas8
{
    public partial class Form1 : Form
    {
        private int comboBox1_SelectedIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      
        {
            if (comboBox1.SelectedItem == "IDR to USD") 
            {
                double a, b;
                a = double.Parse(this.textBox1.Text);
                b = a * 0.000066;
                Math.Round(b, 6);
                this.textBox2.Text = Convert.ToString(b);

            }
            else if (comboBox1.SelectedItem == "IDR to SGD") 
            {
                double a, b;
                a = double.Parse(this.textBox1.Text);
                b = a * 0.000093;
                Math.Round(b, 6);
                this.textBox2.Text = Convert.ToString(b);
            }
            else if (comboBox1.SelectedItem == "IDR to AUD") 
            {
                double a, b;
                a = double.Parse(this.textBox1.Text);
                b = a * 0.00010;
                Math.Round(b, 5);
                this.textBox2.Text = Convert.ToString(b);
            }

            else if (comboBox1.SelectedItem == "USD to IDR") 
            {
                double a, b;
                a = double.Parse(this.textBox2.Text);
                b = a * 15255;
                this.textBox1.Text = Convert.ToString(b);
            }
            else if (comboBox1.SelectedItem == "SGD to IDR") 
            {
                double a, b;
                a = double.Parse(this.textBox2.Text);
                b = a * 10772.10;
                Math.Round(b, 6);
                this.textBox1.Text = Convert.ToString(b);
            }
            else if (comboBox1.SelectedItem == "AUD to IDR")
            {
                double a, b;
                a = double.Parse(this.textBox2.Text);
                b = a * 9810.31;
                Math.Round(b, 5);
                this.textBox1.Text = Convert.ToString(b);
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
