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

namespace Lab10_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);

            double xk = Convert.ToDouble(textBox2.Text);

            double dx = Convert.ToDouble(textBox3.Text);

            double b = Convert.ToDouble(textBox4.Text);

            textBox5.Text = "Результат:" + Environment.NewLine;

            // Цикл для табулирования функции

            double x = x0;

            while (x <= (xk + dx / 2))

            {

                double y = Math.Cos(x)+b-Math.Sin(Math.Pow(x,2));

                textBox5.Text += "x=" + Convert.ToString(x) +

                "; y=" + Convert.ToString(y) + Environment.NewLine;

                x = x + dx;
                this.chart1.Series[0].Points.AddXY(x, y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
