using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    public delegate AccountDetails TransactionDelegate(int userChoice, AccountDetails objAcDtls);
    public delegate void CreateCustomerBankAccount(ref AccountDetails objAD);
    #region AccountDetails class

    public class AccountDetails
    {
        public int AccountTypeID = 0;
        public string AccountHolderName = string.Empty;
        public string ParentAccountName = string.Empty;
        public string Address = string.Empty;
        public int Age = 0;
        public decimal AccountBalance = 500;
        public int ErrorTypeID = 0;
        public string ErrorMessage = string.Empty;
        public int TransactionPerDay = 0;
        public bool IsATMRequired = false;

    }
}
#endregion