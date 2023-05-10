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
    public partial class 作業0704_loan : Form
    {
        public 作業0704_loan()
        {
            InitializeComponent();
        }

        private void btn月付款_Click(object sender, EventArgs e)
        {

            double 月利率 = Convert.ToDouble(txt利率.Text)/100;
            double 月數 = Convert.ToDouble(txt期限.Text) * 12;

            double x =  0.008, y = 月數;
            double result = Math.Pow(x, y);
            //{ [(1 + 0.08)次12] *0.08}÷[[(1 + 0.08)次12] -1}

            //double x = 1+ 月利率, y = 月數;
            //double result = Math.Pow(x, y);

            double 期限年 = Convert.ToDouble(txt期限.Text);
            double 貸款金額 = Convert.ToDouble(txt貸款金額.Text);

            //double 平均攤還率= (result * 月利率) / (result-1);
            double 平均攤還率 = 1+(result * 月利率) / (result) - 1;

            //(result*月利率)/(result－1)
            //{ [(1＋Label月利率)^月數]×Label月利率}÷{ [(1＋Label月利率)^月數]－1}
            //double 平均每月應攤付本息金額 = 貸款金額 * 平均攤還率;
            double 平均每月應攤付本息金額 = 貸款金額 * 平均攤還率;
            //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額

            MessageBox.Show("月付額:" + 平均每月應攤付本息金額 + "元");
        }

        private void btn總付款_Click(object sender, EventArgs e)
        {
            double 貸款金額 = Convert.ToDouble(txt貸款金額.Text);
            //btn總付款.Text
            double 月利率 = Convert.ToDouble(txt利率.Text) / 100;
            double 月數 = Convert.ToDouble(txt期限.Text) * 12;

            double x = 0.008, y = 月數;
            double result = Math.Pow(x, y);
            double 平均攤還率 = 1 + (result * 月利率) / (result) - 1;
            double 平均每月應攤付本息金額 = 貸款金額 * 平均攤還率;


            double btn總付款 = 貸款金額;
            MessageBox.Show("總付款:" + (平均每月應攤付本息金額+ 貸款金額) + "元");
        }
    }
}
