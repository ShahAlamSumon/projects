using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareValue_App
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

        private void showButton_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(textBox1.Text);
            double result = GetDouble(aNumber);

            textBox2.Text = result.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public double GetDouble(double aNumber)
        {
            return aNumber*2;
        }
    }
}
