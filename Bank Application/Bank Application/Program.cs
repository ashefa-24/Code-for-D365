using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice_selected = 0;
            CreateAccount ca = new CreateAccount();
            
            List<AccountDetails> lstCustomerAccounts = new List<AccountDetails>();
            AccountDetails acc_det = null;
            try
            {
                while (choice_selected >= 0)
                {
                    if (choice_selected == 0)
                    {
                        Console.Write("1. Enter 1 to open Savings Bank A/C. \n2. Enter 2 to open Current Bank A/C.\n3. Enter 3 to open Child Bank A/C.\nPlease choose your account type: ");
                        choice_selected = Convert.ToInt32(Console.ReadLine()); 
                        acc_det = new AccountDetails();
                        acc_det.AccountTypeID = choice_selected;
                    }
                    if (choice_selected > 0 && choice_selected <= 3)
                    {
                        CreateCustomerBankAccount objCrtCstData = new CreateCustomerBankAccount(ca.CreateAccountByTypeId);
                        objCrtCstData += ca.DisplayCustomerDetails;
                        objCrtCstData(ref acc_det);
                        lstCustomerAccounts.Add(acc_det);
                        {
                            int intoperation = 0; while (intoperation >= 0 && intoperation <= 3)
                            {
                                Console.WriteLine("\nAs you have opted for ATM facility, please select below operation to perform:\n1. Deposit.\n2. Withdraw.\n3. Check Available Balance.\n4. Exit ATM.");
                                Console.Write("Enter your choice: ");
                                intoperation = Convert.ToInt32(Console.ReadLine()); 
                                if (intoperation >= 1 && intoperation <= 3)
                                {
                                    TransactionDelegate objDel = new TransactionDelegate(ca.PerformATMTransactions);
                                    acc_det = objDel(intoperation, acc_det); 
                                    if (acc_det.TransactionPerDay > 3)
                                    {
                                        ca.ReachingTransactionLimit(acc_det);
                                    }
                                }
                                if (intoperation < 4)
                                {
                                    Console.WriteLine("\n\n****************************************************************");
                                    Console.WriteLine("Enter 0 to do another transaction or enter 4 to exit ATM.");
                                    intoperation = Convert.ToInt32(Console.ReadLine());
                                }
                            };
                        }
                    }
                    else if (choice_selected > 3)
                    {
                        ca.DisplayAllCustomerDetails(lstCustomerAccounts);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice...");
                    }
                    Console.WriteLine("\n\n****************************************************************");
                    Console.WriteLine("Enter 0 to Create account.\nEnter 4 to display all customer details.\nEnter -1 to exit.");
                    Console.Write("Enter Your choice: ");
                    choice_selected = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("****************************************************************\n");
                }; Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nInvalid input, please try again later...");
                Console.ReadKey();
            }
        }
    }
}
