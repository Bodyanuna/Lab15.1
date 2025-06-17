using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0,0";
            textBox2.Text = "0,0";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0.0, y = 0.0;

            if (Double.TryParse(textBox1.Text, out double result)) { x = Convert.ToDouble(textBox1.Text); }
            else { textBox3.Text = "Введіть число у змінну x"; }
            if (Double.TryParse(textBox2.Text, out double result1)) { y = Convert.ToDouble(textBox2.Text); }
            else { textBox3.Text = "Введіть число у змінну y"; }

            if (Double.TryParse(textBox1.Text, out double result2) && Double.TryParse(textBox2.Text, out double result3))
            { textBox3.Text = Convert.ToString(x * Math.Log(x) + y * Math.Cos(x) - Math.Pow(x, 3)); }

        }
    }
}
