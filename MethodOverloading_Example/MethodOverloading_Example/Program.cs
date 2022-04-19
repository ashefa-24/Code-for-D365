using System;

namespace MethodOverloading_Example

{
    public class Bank
    {
        String branchCode;
        String branchName, branchAddress;
        int sal;
        public void dispalyinfo()
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
        public void addSalary(int sal)
        {
            Console.WriteLine("Enter the Amount : ");
        }
        class emp : Bank
        {
            int empId;
            String empName;
            public void show()
            {
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
                e.show();
            }
        }
    }
}

