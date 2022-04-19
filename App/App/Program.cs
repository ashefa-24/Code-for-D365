using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            long basic, da,hra;
            Console.WriteLine("Enter Basic pay :");
            basic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Da pay :");
            da = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter HRA pay :");
            hra = int.Parse(Console.ReadLine());
            Class1 c1 =new Class1();
            c1.Emp_Salary( basic,  da,  hra);
            Console.ReadKey();
        }
    }
}
