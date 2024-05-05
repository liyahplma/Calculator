using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Calculator___Aaliyah
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;

            if (radioButton1.Checked) 
            {
                c = a + b;
                textBox3.Text = c.ToString();
            }

            if (radioButton2.Checked) 
            {
                c = a - b;
                textBox3.Text = c.ToString();
            }

            if (radioButton3.Checked) 
            {
                c = a * b;
                textBox3.Text = c.ToString();
            }

            if (radioButton4.Checked) 
            {
                c = a / b;
                textBox3.Text = c.ToString();
            }

            if (radioButton5.Checked) 
            {
                c = a % b;
                textBox3.Text = c.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
