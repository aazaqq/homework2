using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class 作業0711_MyClac : Form
    {
        public 作業0711_MyClac()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double Answer = Num1 + Num2;

            txtAnswer.Text = Answer.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double Answer = Num1 - Num2;

            txtAnswer.Text = Answer.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double Answer = Num1 * Num2;

            txtAnswer.Text = Answer.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double Num1 = Convert.ToDouble(txtNum1.Text);
            double Num2 = Convert.ToDouble(txtNum2.Text);
            double Answer = Num1 / Num2;

            txtAnswer.Text = Answer.ToString();
        }
    }
}

