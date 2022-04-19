using System;

namespace Constructor
{
    class Bank
    {
        int branchCode;
        public static String branchName;
        public Bank()
        {
            branchCode = 101;
        }
        static Bank()
        {
            branchName = "SBI";
        }
        public void display()
        {
            Console.Write("BranchCode is : " + branchCode);
            branchCode++;
            Console.WriteLine("BranchName is : " + branchName);
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                Bank b1 = new Bank();
                b1.display();
                b1.display();
                Bank b2 = new Bank();
                Bank.branchName = "HDFC";
                b2.display();
            }
        }
    }
}
