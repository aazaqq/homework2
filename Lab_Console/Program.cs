using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入姓名");
            String Name = Console.ReadLine();
            Console.WriteLine("Hello C#"+Name); //"String"   'c'
            Console.ReadKey();
            //todo
            MyClass mc = new MyClass();
            mc.Method04();
        }
    }
}
