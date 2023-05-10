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
    public partial class 作業0710_Student_StructForm : Form
    {
        public 作業0710_Student_StructForm()
        {
            InitializeComponent();
        }
        public string 姓名save;
        public int 國文save;
        public int 英文save;
        public int 數學save;
        private void btn儲存_Click(object sender, EventArgs e)
        {
            姓名save = txt姓名.Text;
            國文save = int.Parse(txt國文.Text);
            英文save = int.Parse(txt英文.Text);
            數學save = int.Parse(txt數學.Text);
        }

        private void btn顯示儲存內容_Click(object sender, EventArgs e)
        {
            LabShow1.Text = $"姓名:{姓名save}\n國文:{國文save}\n英文:{英文save}\n數學:{數學save}";
        }

        private void btn最高分最低分科目_Click(object sender, EventArgs e)
        {
            int[] scores = new int[] { 國文save, 英文save, 數學save };
            int highestScore = scores.Max(); // 取得最高分
            int lowestScore = scores.Min(); // 取得最低分

            string highestSubject = "";
            string lowestSubject = "";

            // 判斷最高分和最低分的科目
            if (highestScore == 國文save)
            {
                highestSubject = "國文";
            }
            else if (highestScore == 英文save)
            {
                highestSubject = "英文";
            }
            else if (highestScore == 數學save)
            {
                highestSubject = "數學";
            }

            if (lowestScore == 國文save)
            {
                lowestSubject = "國文";
            }
            else if (lowestScore == 英文save)
            {
                lowestSubject = "英文";
            }
            else if (lowestScore == 數學save)
            {
                lowestSubject = "數學";
            }

            LabShow2.Text = $"最高科目成績為:{highestSubject}{highestScore}分\n最低科目成績為:{lowestSubject}{lowestScore}分";
        }
    }
}
