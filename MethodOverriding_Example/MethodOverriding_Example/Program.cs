using System;

namespace MethodOverriding_Example
{
    public class Bank
    {
        String branchCode;
        String branchName, branchAddress;
        public virtual void dispalyinfo()
        {
            Console.WriteLine("enter branch details");
            Console.WriteLine("Enter Branch Name : ");
            branchName = Console.ReadLine();
            Console.WriteLine("Enter Branch Address : ");
            branchAddress = Console.ReadLine();
            Console.WriteLine("Enter Branch Code : ");
            branchCode = Console.ReadLine();

            Console.WriteLine("enter branch details : " + branchCode + " " + branchName + " " + branchAddress);
        }
        class emp : Bank
        {
            int empId;
            String empName;
            public override void dispalyinfo()
            {
                base.dispalyinfo();
                Console.WriteLine("Enter Employee details");
                Console.WriteLine("Enter Id : ");
                empId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                empName = Console.ReadLine();
            }
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                emp e = new emp();
                e.dispalyinfo();
            }
        }
    }
}

