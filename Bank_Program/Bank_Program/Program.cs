using System;

namespace Bank_Program
{
    class Bank
    {
        string branchcode, branchname, branchaddress;
        public void GetBranchinfo()
        {
            Console.WriteLine("Enter Branch Details :");
            Console.WriteLine("==========================");
            Console.WriteLine("Enter Branch Name :");
            branchname = Console.ReadLine();
            Console.WriteLine("Enter Branch Address :");
            branchaddress = Console.ReadLine();
            Console.WriteLine("Enter Branch Code :");
            branchcode = Console.ReadLine();
        }
        public void displayinfo()
        {
            Console.WriteLine(" Branch Code : {0}, Branch Name : {1}, Branch Address : {2} ", branchcode, branchname, branchaddress);
        }
        public void displayinfo(int id, String name)
        {
            Console.WriteLine(" Employee ID : {0}, Employee Name : {1} ", id, name);
        }
    }
    class Account : Bank
    {

        public virtual void cash()
        {
            Console.WriteLine("To check the balance :");
        }

    }
    class ATM : Account
    {
        int amt = 50000;
        int n;
        public override void cash()
        {
            Console.WriteLine(" To check the balance amount in the Account -> Enter 1");
            Console.WriteLine(" =================================================================");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
                Console.WriteLine(" Total amount in the account is {0} ", amt);
            else
                Console.WriteLine("Invalid Option");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int empid;
            string empname;
            Console.WriteLine("Enter Employee Details :");
            Console.WriteLine("===============================");
            Console.WriteLine("Enter Employee ID :");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name :");
            empname = Console.ReadLine();
            ATM e = new ATM();
            e.GetBranchinfo();
            e.displayinfo();
            e.displayinfo(empid, empname);
            Console.WriteLine("===============================");
            e.cash();
            Console.ReadKey();
        }
    }
}
