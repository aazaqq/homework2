using Lab_Form.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace WindowsFormsApplication1
{

    public partial class 作業ScreenSaver : Form
    {
        public 作業ScreenSaver()
        {
            InitializeComponent();
        }
        //int i = 0, StartOrStop = 0, r, g, b, counter = 0;
        //float t, x = 125, y = 100, v = 250, d = 200;

        //public  int screenWidth;
        //public int screenHeight;
        //public Bitmap bitmap = new Bitmap("C:\\Shard\\Lab_Csharp\\Lab_Csharp\\Lab_Form\\Resources\\picturebox3.gif");
        //public Random random = new Random();
        //public int x = 0;
        //public int y = 0;
        //Rectangle rect = Screen.PrimaryScreen.Bounds;
        int curP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //screenWidth = rect.Width;
            //screenHeight = rect.Height;
            //string currPath = System.Environment.CurrentDirectory + "C:\\Shard\\Lab_Csharp\\Lab_Csharp\\Lab_Form\\Resources\\picturebox3.gif";
            //bitmap = new Bitmap(currPath, true);
            //x = random.Next(screenWidth);
            //y = random.Next(screenHeight);
            //if (x + bitmap.Width > screenWidth)
            //{
            //    x = screenWidth - bitmap.Width;
            //}
            //if (y + bitmap.Height > screenHeight)
            //{
            //    y = screenHeight - bitmap.Height;
            //}
            this.Invalidate();

            curP += 1;
            if (curP > 5) { curP=1; }
            switch(curP)
            {
                case 1:
                    this.BackgroundImage=Lab_Form.Properties.Resources.picturebox1;
                    break;
                case 2:
                    this.BackgroundImage = Lab_Form.Properties.Resources.picturebox2;
                    break;
               case 3:
                    this.BackgroundImage = Lab_Form.Properties.Resources.picturebox3;
                    break;
                case 4:
                    this.BackgroundImage = Lab_Form.Properties.Resources.picturebox4;
                    break;
                case 5:
                    this.BackgroundImage = Lab_Form.Properties.Resources.picturebox5;
                    break;
            }
        }

        private void 作業ScreenSaver_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void 為之2_Paint(object sender, PaintEventArgs e)
        //{
        //    //    e.Graphics.DrawImage(bitmap, x, y,bitmap.Width,bitmap.Height);
        //    e.Graphics.DrawImage(bitmap, 60,60);
        //}

        //private void 作業ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //Application.Exit();
        //}

        //private void 為之2_Load(object sender, EventArgs e)
        //{
        //    timer1.Start();
        //}
    }
}

    //Random R = new Random();
    //Random G = new Random();y
    //Random B = new Random();

    //Graphics gr; //建立繪圖介面類別g
    //Pen p = new Pen(Color.Blue); //建立繪圖物件p(一枝筆顏色為藍色)
    //Pen p1 = new Pen(Color.Yellow);
    //Pen p2 = new Pen(Color.Red);
    ////Pen p3 = new Pen(Color.Green);
    ////Pen p4 = new Pen(Color.LightSteelBlue);
    //Pen p5 = new Pen(Color.LightSteelBlue);

//}

