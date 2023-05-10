using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()
        { MessageBox.Show("Method01"); }
        private void Method02()
        { MessageBox.Show("Method02 private"); }
        internal void Method03()
        { MessageBox.Show("Method03 internal"); }
        public void Method04()
        { MessageBox.Show("Method04 public"); }
        public void Method05()
       {Method01();
        Method02(); }

    }
   public class Member
{ public string Name;
    public int Age;
}
public class StaticLab
{ public int instanceNum;
    public static int staticNum;
} }

//定義2個(靜態與非靜態的變數)

public enum UserRole
{ Admin = 1,
    User,
    Student
}

public struct Employee
{
    public string Name;
    public int Age;

    //public string Name { get; set; } //如果結構裡面有屬性的話，就必須欄位變成屬性，且必須要這樣子寫
    //public int Age { get; set; } //如果結構裡面有屬性的話，就必須欄位變成屬性，且必須要這樣子寫

    public Employee(string EmployeeName, int EmployeeAge)  //建構函式
    {
       Name = EmployeeName;
        Age = EmployeeAge;
    }
}
public struct Product
{
    public string Name;
    public int Price;
}