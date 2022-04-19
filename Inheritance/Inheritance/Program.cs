using System;

namespace Inheritance
{
    class Bank
    {
        String branchCode;
        String branchName, branchAddress;
        public void GetBranchinfo()
        {
            Console.WriteLine("enter branch details");
            Console.WriteLine("Enter Branch Name : ");
            branchName = Console.ReadLine();
            Console.WriteLine("Enter Branch Address : ");
            branchAddress = Console.ReadLine();
            Console.WriteLine("Enter Branch Code : ");
            branchCode = Console.ReadLine();
        }
        public void dispalyinfo()
        {
            Console.WriteLine("enter branch details : " + branchCode+" " + branchName+" "+ branchAddress);
        }
        class emp : Bank
        {
            int empId;
            String empName;
            public void EmpData()
            {
                Console.WriteLine("Enter Employee details");
                Console.WriteLine("Enter Id : ");
                empId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name");
                empName = Console.ReadLine();
            }
        }
        class Hdfc : emp
        {
            public void show()
            {
                Console.WriteLine("This Account is placed");
            }
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                Hdfc e = new Hdfc();
                e.EmpData();
                e.GetBranchinfo();
                e.dispalyinfo();
                e.show();
            }
        }
    }
}
