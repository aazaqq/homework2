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
    public partial class 作業考試_Alarm : Form
    {
        public 作業考試_Alarm()
        {
            InitializeComponent();
            LabTimer.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabTimer.Text = DateTime.Now.ToString();
        }

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        int a = 100;
        private void timer2_Tick(object sender, EventArgs e)

        { 
            {
                a = a - 1;
                LabShowTimer.Text =(a / 60).ToString() + "分" + (a % 60).ToString() + "秒";

                if (a == 0)
                {
                    timer2.Stop();
                }
            }
        }
    }
}
