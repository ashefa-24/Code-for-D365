using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exception
{
    public class Error : Exception
    {
        public Error(String message) : base(message)
        {

        }

    }
    class Bank
    {
        String branchCode;
        String branchName, branchAddress;
        String Acc_name;
        int Acc_Amount;
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
            Console.WriteLine("enter branch details : " + branchCode + " " + branchName + " " + branchAddress);
        }
        public int Savings_Account()
        {
            try
            {
                Console.WriteLine("Currently you are in Savings Account");
                Console.WriteLine("Your daily limit is 100000");
                Console.Write("Enter Account Holder Name:\t");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if(Acc_Amount > 100000)
                {
                    Console.WriteLine("The amount is exceeding please check the amount");
                }
                else
                {
                    Console.WriteLine("The amount is deposited");
                }
            }
            //catch (Errors e){
            //    Console.Write()
           catch{ }
            return 1;
        }
        public int Current_Account()
        {
            try
            {
                Console.WriteLine("Currently you are in Current Account");
                Console.WriteLine("Your daily limit is 200000");
                Console.Write("Enter Account Holder Name:\t");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 200000)
                {
                    Console.WriteLine("The amount is exceeding please check the amount");
                }
                else
                {
                    Console.WriteLine("The amount is deposited");
                }
            }
            catch { }
            return 2;
        }
        public int ChildCare_Account()
        {
            try
            {
                Console.WriteLine("Currently you are in ChildCare Account");
                Console.WriteLine("Your daily limit is 500000");
                Console.Write("Enter Account Holder Name:\t");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 500000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    Console.WriteLine("The amount is deposited");
                }
            }
            catch(Error e) {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Write("The amount deposited is : " + Acc_Amount);
            }
            return 3;
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                //Hdfc e = new Hdfc();
                //e.EmpData();
                //e.GetBranchinfo();
                //e.dispalyinfo();
                //e.show();
                int choice_selected;
                String ch;
                Bank bank = new Bank();
                for(; ; )
                {
                    Console.WriteLine("******************");
                    Console.WriteLine("Enter any one number to proceed further : \t 1.Savings Account\t 2. Current Account\t 3. ChildCare Account\t 4. Exit");
                    Console.WriteLine("******************");
                    ch = Console.ReadLine();

                    switch(ch)
                    {
                        case "1":
                            choice_selected = bank.Savings_Account();
                            //Console.WriteLine("SAvings");
                            break;
                        case "2":
                            choice_selected = bank.Current_Account();
                            //Console.Write("Current");
                            break;
                        case "3":
                            choice_selected = bank.ChildCare_Account();
                            //Console.Write("ChildCare");
                            break;
                        case "4":
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice!!");
                            break;

                    }
                    
                }

            }
        }
    }
}
