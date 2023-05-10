using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Lab_Form
{
    public partial class HomePage : Form
    {
        //private Form currentForm;
        public HomePage()
        {
            InitializeComponent();
        }
        //PRIVATE VOID SHOWFORM(Form FRM)
        //\IF(FORMNOW!NULL)
        //{
        //    FORMNOW.CLOSE();

        //}
        //FORMNOW=Frm_M02_HelloForm;
        //    FRM.TOPLEVEL=false;
        //    FRM.PARENT=SPILTCONTAINER2.PANEL2;
        //    FRM.SHOW();

        private 作業0703_Hello Hello;

        private void 作業0703_Hello_Click(object sender, EventArgs e)
        {

            Hello = new 作業0703_Hello();
            //Hello.Show();
            Hello.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(Hello);
            Hello.Show();
            //if (Hello != null)
            //{
            //    Hello.Close();
            //}
        }

        private 作業0704_loan loan;
        private void 作業0704_loan_Click(object sender, EventArgs e)
        {
            if (Hello != null)
            {
                Hello.Close();
            }
            loan = new 作業0704_loan();
            //loan.Show();
            loan.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(loan);
            loan.Show();

            //loan.TopLevel = !false;
            //loan.Close();

        }
        private 作業0710_Student_StructForm Student;
        private void 作業0710_Student_StructForm_Click(object sender, EventArgs e)
        {
            if (loan != null)
            {
                loan.Close();
            }
            Student = new 作業0710_Student_StructForm();
            //Student.Show();
            Student.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(Student);
            Student.Show();
        }
        private 作業0711_MyClac MyClac;
        private void 作業0711_MyClac_Click(object sender, EventArgs e)
        {
            if (Student != null)
            {
                Student.Close();
            }
            MyClac = new 作業0711_MyClac();
            //MyClac.Show();
            MyClac.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(MyClac);
            MyClac.Show();
        }
        private 作業ScreenSaver ScreenSaver2;
        private void 作業ScreenSaver_Click(object sender, EventArgs e)
        {
            if (MyClac != null)
            {
                MyClac.Close();
            }
            ScreenSaver2 = new 作業ScreenSaver();
            //ScreenSaver2.TopLevel=false;
            //splitContainer3.Panel2.Controls.Add(ScreenSaver2);
            ScreenSaver2.Show();
        }
        private Myhomework_0718_Notepad Notepad;
        private void 作業Notepad_Click(object sender, EventArgs e)
        {
            if (ScreenSaver2 != null)
            {
                ScreenSaver2.Close();
            }
            Notepad = new Myhomework_0718_Notepad();
            //Notepad.Show();
            Notepad.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(Notepad);
            Notepad.Show();
        }
        private 作業小畫家 小畫家;
        private void 作業小畫家2_Click(object sender, EventArgs e)
        {
            if (Notepad != null)
            {
                Notepad.Close();
            }
            小畫家 = new 作業小畫家();
            //小畫家2.Show();
            小畫家.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(小畫家);
            小畫家.Show();
        }
        private 作業考試_Guess Guess;
        private void 作業考試_Guess_Click(object sender, EventArgs e)
        {
            if (小畫家 != null)
            {
                小畫家.Close();
            }
            Guess = new 作業考試_Guess();
            //Guess.Show();
            Guess.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(Guess);
            Guess.Show();
        }
        private 作業考試_Alarm Alarm;
        private void 作業考試_Alarm_Click_1(object sender, EventArgs e)
        {
            if (Guess != null)
            {
                Guess.Close();
            }

            Alarm = new 作業考試_Alarm();
            //Alarm.Show();
            Alarm.TopLevel = false;
            splitContainer3.Panel2.Controls.Add(Alarm);
            Alarm.Show();

            //if (Alarm != null)
            //{
            //    Hello.Show();
            //}
        }
    }
}

