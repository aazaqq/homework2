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
    public partial class 作業考試_Guess : Form
    {
        int num;
        string str;
        int b = 0;
        public 作業考試_Guess()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //private void btnGuess_Click(object sender, EventArgs e)
        //private void txtShow_Click(object sender, EventArgs e)
        //        {

        //        }
        private void 作業考試_Guess_Load(object sender, EventArgs e)
        {
            //this.輸入0到99之間的整數 ="輸入0";
            this.Text = "猜數字遊戲";
            this.button1.Text = "開始遊戲";
            this.button2.Text = "結束";
            this.textbox1.ReadOnly = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.textbox1.ReadOnly = false;
            Random random = new Random();
            num = random.Next(0, 99);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                str = textbox1.Text; ;
                b = int.Parse(str);
                if (b > num)
                {
                    DialogResult d = MessageBox.Show("大了", "", MessageBoxButtons.OK);
                }
                else if (b < num)
                {
                    DialogResult d = MessageBox.Show("小了", "", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult d = MessageBox.Show("猜中了", "", MessageBoxButtons.OK);
                    this.textbox1.Text = null;
                    this.textbox1.ReadOnly = true;
                }
            }
            //this.txtShow.Text
            //{
            //    int SecretNum = 100;
            //    int Guess;
            //    //string Result = Convert.ToString(Guess);
            //    do
            //    {
            //        //MessageBox.Show(Guess);
            //        Guess = (int)(MessageBox.Show(txtShow.Text));

            //        if (Guess < SecretNum)
            //        {
            //            MessageBox.Show("太小了");
            //        }
            //        else if (Guess > SecretNum)
            //        {
            //            MessageBox.Show("太大了");
            //        }
            //        else
            //        { MessageBox.Show("你答對了"); }
            //    }
            //    while (Guess != SecretNum);
            //}
            //DialogResult()
            //private void btnShowAnswer_Click(object sender, EventArgs e)
            //{
            //    MessageBox.Show()
            //}
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                str = textbox1.Text; ;
                b = int.Parse(str);
                if (b > num)
                {
                    DialogResult d = MessageBox.Show("大了", "", MessageBoxButtons.OK);
                }
                else if (b < num)
                {
                    DialogResult d = MessageBox.Show("小了", "", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult d = MessageBox.Show("猜中了", "", MessageBoxButtons.OK);
                    this.textbox1.Text = null;
                    this.textbox1.ReadOnly = true;
                }


            }
        }
    }
}
