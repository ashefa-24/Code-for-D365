using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public void Emp_Salary(long basic, long da, long hra)
        {
            long Monthly = basic + da + hra;
            Console.WriteLine("Monthly salary :"+ Monthly);
            

        }
    }
}
