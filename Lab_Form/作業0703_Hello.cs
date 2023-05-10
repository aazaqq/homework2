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
    public partial class 作業0703_Hello : Form
    {
        public 作業0703_Hello()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string Name=txtName.Text;
            string EnglishName=txtEnglishName.Text;
            string Gender=txtGender.Text;
            string Horoscope=txtHoroscope.Text;
            MessageBox.Show("Hello~~" + "\r\n" + "我是" + Name + "\r\n"+"英文名:"+EnglishName+ "\r\n"+ "性別:"+Gender + "\r\n"+ "星座:"+Horoscope+"\r\n"+"很高興認識你~");

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EnglishName = txtEnglishName.Text;
            string Gender = txtGender.Text;
            string Horoscope = txtHoroscope.Text;
            MessageBox.Show("Hi~~" + "\r\n" + "我是" + Name + "\r\n" + "英文名:" + EnglishName + "\r\n" + "性別:"+ Gender + "\r\n" +"星座:"+ Horoscope+"\r\n" +"很高興認識你~");
        }
    }
}
//todo