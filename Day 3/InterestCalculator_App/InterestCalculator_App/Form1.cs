using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectbank.Text=="Brac")
            {
                textResult.Text = (double.Parse(textTime.Text)*double.Parse(textBalance.Text)*.06).ToString();
            }
            else if (selectbank.Text=="DBBL")
            {
                textResult.Text = (double.Parse(textTime.Text) * double.Parse(textBalance.Text) * .07).ToString();
            }
            else if (selectbank.Text=="HSCB")
            {
                textResult.Text = (double.Parse(textTime.Text) * double.Parse(textBalance.Text) * .08).ToString();
            }
            else
            {
                Close();
            }
        }

       

        
    }
}
