using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            double y = 0;

            if ((x + 2) <= 1)
                y = x * x;
            else if (1 < (x + 2) && (x + 2) < 10)
                y = 1 / (x + 2);
            else
                y = x + 2;

            return y;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(a_t.Text);
            double b = Convert.ToDouble(b_t.Text);
            double h = Convert.ToDouble(h_t.Text);

            for (double i = a; i <= b; i += h)
            {
                y_t.Text += "f";
                y_t.Text += "(";
                y_t.Text += i;
                y_t.Text += ")";
                y_t.Text += "=";
                y_t.Text += f(i);
                y_t.Text += Environment.NewLine;
            }
        }
    }
}
