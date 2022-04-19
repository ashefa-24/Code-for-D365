using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    #region Create Account Class
    class CreateAccount
    {
        public void CreateAccountByTypeId(ref AccountDetails choice)
        {
            try
            {
                Console.WriteLine();
                switch (choice.AccountTypeID)
                {
                    case 1:
                        Console.WriteLine("Please Enter Savings Bank Account Details: ");
                        Console.WriteLine("==============================================");
                        choice = CapturerCustomerDetails(choice); 
                        break;
                    case 2:
                        Console.WriteLine("Please Enter Current Bank Account Details: ");
                        Console.WriteLine("============================================== ");
                        choice = CapturerCustomerDetails(choice); 
                        break;
                    case 3:
                        Console.WriteLine("Please Enter Child Bank Account Details: ");
                        Console.WriteLine("============================================== ");
                        choice = CapturerCustomerDetails(choice); 
                        break;
                }
            }
            catch (Exception ex)
            {
                choice.ErrorMessage = "There is an error while creating the account: " + ex.Message;
                choice.ErrorTypeID = 1;
            }
        }
        public AccountDetails CapturerCustomerDetails(AccountDetails accountDetails)
        {
            try
            {
                if (accountDetails.AccountTypeID == 3)
                {
                    Console.Write("Enter Parent Account Holder Name: ");
                    accountDetails.ParentAccountName = Console.ReadLine();
                }
                Console.Write("Enter your Name: ");
                accountDetails.AccountHolderName = Console.ReadLine();
                Console.Write("Enter your Address: ");
                accountDetails.Address = Console.ReadLine();
                Console.Write("Do you want an ATM Card (Enter 1 for Yes. Enter 2 for No): ");
                int ATMId = Convert.ToInt32(Console.ReadLine());
                accountDetails.IsATMRequired = ATMId == 1 ? true : false; if (accountDetails.AccountTypeID == 1)
                {
                    if (accountDetails.AccountBalance > 100000)
                    {
                        accountDetails.ErrorTypeID = 2;
                        accountDetails.ErrorMessage = "For Savings Bank Account the limit is 100000, please try again later.\nThank you for Banking with us, have a great day.";
                    }
                }
                else if (accountDetails.AccountTypeID == 2)
                {
                    if (accountDetails.AccountBalance > 200000)
                    {
                        accountDetails.ErrorTypeID = 2;
                        accountDetails.ErrorMessage = "For Current Bank Account the limit is 200000, please try again later.\nThank you for Banking with us, have a great day.";
                    }
                }
                else if (accountDetails.AccountTypeID == 3)
                {
                    if (accountDetails.AccountBalance > 50000)
                    {
                        accountDetails.ErrorTypeID = 2;
                        accountDetails.ErrorMessage = "For Child Bank Account the limit is 50000, please try again later.\nThank you for Banking with us, have a great day.";
                    }
                }
            }
            catch (Exception ex)
            {
                accountDetails.ErrorMessage = "There is an error while creating the account: " + ex.Message;
                accountDetails.ErrorTypeID = 1;
            }
            return accountDetails;
        }
        public void DisplayCustomerDetails(ref AccountDetails objAcDtls)
        {
            if (objAcDtls.ErrorTypeID > 0)
            {
                Console.WriteLine(objAcDtls.ErrorMessage);
            }
            else
            {
                int id = objAcDtls.AccountTypeID; Console.WriteLine("\n****************************************************************");
                Console.WriteLine("Congratulations Your Account has been created successfully...");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Account Type\t= {0}", id == 1 ? "Savings" : (id == 2 ? "Current" : "Child"));
                if (objAcDtls.AccountTypeID == 3)
                {
                    Console.WriteLine("Parent Account Name\t = {0}", objAcDtls.ParentAccountName);
                }
                Console.WriteLine("Account Name\t= {0}", objAcDtls.AccountHolderName);
                Console.WriteLine("Age  \t= {0}", objAcDtls.Age);
                Console.WriteLine("Address  \t= {0}", objAcDtls.Address);
                Console.WriteLine("A/C Balance\t= {0}", objAcDtls.AccountBalance);
                if (objAcDtls.IsATMRequired)
                {
                    Console.WriteLine("Opted for ATM\t= {0}", objAcDtls.IsATMRequired);
                }
                Console.WriteLine("****************************************************************");
            }
        }
        public AccountDetails PerformATMTransactions(int choice, AccountDetails objACDtls)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter amount to be deposited: ");
                    decimal depAmt = Convert.ToDecimal(Console.ReadLine());
                    objACDtls.AccountBalance = objACDtls.AccountBalance + depAmt;
                    Console.WriteLine("\nYour Update balance\t= {0}", objACDtls.AccountBalance);
                    objACDtls.TransactionPerDay = objACDtls.TransactionPerDay + 1;
                    break;
                case 2:
                    Console.Write("Please enter amount to be deposited: ");
                    decimal wdAmt = Convert.ToDecimal(Console.ReadLine());
                    objACDtls.AccountBalance = objACDtls.AccountBalance - wdAmt;
                    Console.WriteLine("\nYour Update balance\t= {0}", objACDtls.AccountBalance);
                    objACDtls.TransactionPerDay = objACDtls.TransactionPerDay + 1;
                    break;
                case 3:
                    Console.WriteLine("\nYour Available Balance is\t: {0}", objACDtls.AccountBalance);
                    break;
            }
            return objACDtls;
        }
        public void DisplayAllCustomerDetails(List<AccountDetails> lstAccounts)
        {
            int SNO = 0;
            Console.WriteLine("||********************************************************************************************************||");
            Console.WriteLine("||S.No ||  A/C Type  ||  \tA/C Name\t  ||  Age  ||  \tAddress\t\t  ||  Balance    ||  ATM  ||");
            Console.WriteLine("||********************************************************************************************************||"); foreach (AccountDetails objAC in lstAccounts)
            {
                int id = objAC.AccountTypeID; Console.Write("|| " +
                    SNO + 1 + "  ||  " +
                    (id == 1 ? "Savings" : (id == 2 ? "Current" : "Child  ")) + "   ||" + "   " +
                    objAC.AccountHolderName + "  \t\t" + " || " + objAC.Age + objAC.Address + objAC.AccountBalance + objAC.IsATMRequired
                    );
                Console.WriteLine("\n||--------------------------------------------------------------------------------------------------------||");
            }
        }
        public void ReachingTransactionLimit(AccountDetails objACDtls)
        {
            Console.WriteLine("\nYou have reached daily transaction limit (i.e: 3), so Amount of 500 is being deducted from your account.");
            Console.WriteLine("Balance before deductions\t = {0}", objACDtls.AccountBalance);
            objACDtls.AccountBalance = objACDtls.AccountBalance - 500;
            Console.WriteLine("Available balance\t = {0}", objACDtls.AccountBalance);
        }
    }
}
#endregion
