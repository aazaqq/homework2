using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Form
{
    public partial class Myhomework_0718_Notepad : Form
    {
        public Myhomework_0718_Notepad()
        {
            InitializeComponent();
            LabTimer.Text = DateTime.Now.ToString();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Bitmap bmp = new Bitmap(320, 210);
            //Graphics g = Graphics.FromImage(bmp);
            //int PenPixel = 2;
            //Pen p1=new Pen(Color.Red);
            //g.DrawLine(p1, 50, 50, 100, 100);
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (自動換行ToolStripMenuItem.Checked == true)
            {
                textBox1.WordWrap = false;
                自動換行ToolStripMenuItem.Checked = false;
            }
            else
            {
                textBox1.WordWrap = true;
                自動換行ToolStripMenuItem.Checked = true;
            }
        }
        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DialogResult result;
                result = MessageBox.Show("此版本為學員在資策會C#的記事本作業1.0版，敬請安心使用。", "關於");

            }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//設為空字串，相當於清除資料
            textBox1.Clear();//把 textBox1的內容clear
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)/*判斷回傳*/
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default); /*開檔<開textBox1.Text>(舊檔路徑,編碼)*/
            }
        }

        private void 新增_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";//設為空字串，相當於清除資料
            textBox1.Clear();//把 textBox1的內容clear

        }

        private void 開啟_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)/*判斷回傳*/
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.Default); /*開檔<開textBox1.Text>(舊檔路徑,編碼)*/
            }
        }

        private void 儲存_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
                }
            }
            else
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox1.Text, Encoding.Default);
            }
        }
        private void 剪下_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void 說明_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("此版本為學員在資策會C#的記事本作業1.0版，敬請安心使用。", "關於");
        }



        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabTimer.Text = DateTime.Now.ToString();
        }
    }
}
