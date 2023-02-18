using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void Calculate()
        {
            double a, b, c, delta, x1, x2;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                lblX1.Text = x1.ToString();
                lblX2.Text = x2.ToString();
        
                lblX1.Visible = true;
                lblX2.Visible = true;
            }
            else if (delta == 0)
            {
                x1 = (-b) / (2 * a);
                lblX1.Text = x1.ToString();
                lblX2.Visible = true;
           
                lblX1.Visible = true;
                lblX2.Visible = false;
            }
            else
            {
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-delta) / (2 * a);
                lblX1.Text = realPart.ToString("0.##") + "+" + imaginaryPart.ToString("0.##") + "i";
                lblX2.Text = realPart.ToString("0.##") + "-" + imaginaryPart.ToString("0.##") + "i";
              
     
                lblX1.Visible = true;
                lblX2.Visible = true;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
