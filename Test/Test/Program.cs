using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    public class Error : Exception
    {
        public Error(String message) : base(message)
        {

        }

    }
    public delegate int AccountDeposit();
    class Bank
    {
        string Acc_name, Address;
        int Acc_Amount, Acc_Number, am_wd;
        string choice;
        int Balance = 500;
        int count = 0;
        int user_choice, Account_Type, no_of_customer;
        Customer cus1 = new Customer();
        public void DisplayCustomerDetails()
        {
            Employee emp = new Employee()
            {
                id = 101,
                name = "Ashefa",
                Gender = "Female",
                salary = 50000
            };
            Employee emp1 = new Employee()
            {
                id = 102,
                name = "Shidharth",
                Gender = "Male",
                salary = 50500

            };
            Employee emp2 = new Employee()
            {
                id = 103,
                name = "Afridha",
                Gender = "Female",
                salary = 45000
            };
            Employee emp3 = new Employee()
            {
                id = 104,
                name = "Suriya",
                Gender = "Male",
                salary = 48000
            };

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp);
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            Console.Write("List of Employees are displayed below\n");
            foreach (Employee employees in employeeList)
            {
                Console.WriteLine("id={0} || name={1} || gender={2} || Salary={3}", employees.id, employees.name, employees.Gender, employees.salary);
            }
        }
        public int Savings_Account()
        {
            try
            {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("Currently you are in Savings Account");
                Console.WriteLine("Your daily limit is 100000");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 100000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    Balance = Balance + Acc_Amount;
                    Console.WriteLine("The amount is deposited");
                    Console.Write("The amount deposited is : " + Balance);
                }
                Console.WriteLine("\nIf you need ATM Card!!! Press\n 1. To WithDraw \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (count < 3)
                        {
                            Console.WriteLine("\n---------------------------------------");
                            Console.WriteLine("ATM Card WithDrawl is Processing");
                            Console.Write("Enter the amount to be withdrawl:\n");
                            am_wd = int.Parse(Console.ReadLine());
                            if (Balance == 0)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else if (am_wd > Balance)
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            else
                            {
                                Balance = Balance - am_wd;
                                Console.Write("Balance: " + Balance);
                            }
                            Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("\nDo you want to continue?");
                            Console.Write("Press\n1.Yes\n2.No\n");

                            user_choice = int.Parse(Console.ReadLine());
                            count++;
                            if (count == 3)
                            {
                                Balance = Balance - 500;
                                Console.Write("Current Balance is: " + Balance);
                                Console.WriteLine("\nAs you have exceeded the limit we have debited Rs-500/ from your account");
                                Console.WriteLine("\nYou have exceeded the limit please wait for next 24 hours");
                            }
                            if (user_choice == 2)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "2":
                        return 1;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 1;
        }
        public int Current_Account()
        {
            try
            {
                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("Currently you are in Current Account");
                Console.WriteLine("Your daily limit is 200000");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 200000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    this.Balance = Balance + Acc_Amount;
                    Console.WriteLine("The amount is deposited");
                    Console.Write("The amount deposited is : " + this.Balance);
                }
                Console.WriteLine("\nIf you need ATM Card!!! Press\n 1. To Activate \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (count < 3)
                        {
                            Console.WriteLine("\n---------------------------------------");
                            Console.WriteLine("ATM Card WithDrawl is Processing");
                            Console.Write("Enter the amount to be withdrawl:\n");
                            am_wd = int.Parse(Console.ReadLine());
                            if (Balance == 0)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else if (am_wd > Balance)
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            else
                            {
                                Balance = Balance - am_wd;
                                Console.Write("Balance: " + Balance);
                            }
                            Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("\nDo you want to continue?");
                            Console.Write("Press\n1.Yes\n2.No\n");

                            user_choice = int.Parse(Console.ReadLine());
                            count++;
                            if (count == 3)
                            {
                                Balance = Balance - 500;
                                Console.Write("Current Balance is: " + Balance);
                                Console.WriteLine("\nAs you have exceeded the limit we have debited Rs-500/ from your account");
                                Console.WriteLine("\nYou have exceeded the limit please wait for next 24 hours");
                            }
                            if (user_choice == 2)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "2":
                        return 2;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 2;
        }
        public int ChildCare_Account()
        {
            try
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("Currently you are in ChildCare Account");
                Console.WriteLine("Your daily limit is 500000");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 500000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    Balance = Balance + Acc_Amount;
                    Console.WriteLine("The amount is deposited");
                    Console.Write("The amount deposited is : " + Balance);
                }
                Console.WriteLine("\nIf you need ATM Card!!! Press\n 1. To Activate \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (count < 3)
                        {
                            Console.WriteLine("\n---------------------------------------");
                            Console.WriteLine("ATM Card WithDrawl is Processing");
                            Console.Write("Enter the amount to be withdrawl:\n");
                            am_wd = int.Parse(Console.ReadLine());
                            if (Balance == 0)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else if (am_wd > Balance)
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            else
                            {
                                Balance = Balance - am_wd;
                                Console.Write("Balance: " + Balance);
                            }
                            Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("\nDo you want to continue?");
                            Console.Write("Press\n1.Yes\n2.No\n");

                            user_choice = int.Parse(Console.ReadLine());
                            count++;
                            if (count == 3)
                            {
                                Balance = Balance - 500;
                                Console.Write("Current Balance is: " + Balance);
                                Console.WriteLine("\nAs you have exceeded the limit we have debited Rs-500/ from your account");
                                Console.WriteLine("\nYou have exceeded the limit please wait for next 24 hours");
                            }
                            if (user_choice == 2)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "2":
                        return 3;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 3;
        }
        public void CreateAccount()
        {
            StreamWriter sw = new StreamWriter("D:\\Employee.txt");
            Console.Write("**Hello!!Welcome to bank application**\n");
            Console.Write("Please Enter the number of customer you want to add\n");
            no_of_customer = int.Parse(Console.ReadLine());
            for (int i = 0; i < no_of_customer; i++)
            {
                Customer cus1 = new Customer();
                Console.Write("\nEnter the Account Holder Name:\n");
                Acc_name = Console.ReadLine();
                cus1.Acc_name = Acc_name;
                sw.WriteLine(cus1.Acc_name);
                Console.WriteLine("Enter Account Number");
                Console.Write("Enter the Last Four Digit of ur account number: \n");
                Acc_Number = int.Parse(Console.ReadLine());
                cus1.Acc_Number = Acc_Number;
                sw.WriteLine(cus1.Acc_Number);
                Console.Write("Enter the Address:\n");
                Address = Console.ReadLine();
                cus1.Address = Address;
                sw.WriteLine(cus1.Address);
                Console.Write("Enter the account type\n");
                Console.Write("Press 1. For Savings\n 2. For Current\n 3. For ChildCare\n");
                Console.Write("~~~~~~~~~~~~~~~~~~\n");
                Account_Type = int.Parse(Console.ReadLine());
                cus1.Account_Type = Account_Type;
                sw.WriteLine(cus1.Account_Type);
                Console.Write("\nThe Option you have selected: " + Account_Type);
                cus1.Balance = 0;
                if (Account_Type == 1)
                {
                    Savings_Account();
                }
                else if (Account_Type == 2)
                {
                    Current_Account();
                }
                else
                {
                    ChildCare_Account();
                }
                cus1.Balance = Balance;
                sw.WriteLine(cus1.Balance);
                List<Customer> customerList = new List<Customer>();
                customerList.Add(cus1);
                foreach (Customer customer in customerList)
                {
                    Console.Write("List of Customer are displayed below\n");
                    Console.WriteLine("Acc_name || Acc_Number || Address || Account_Type || Balance");
                    Console.WriteLine("{0}      || {1}        || {2}     || {3}  || {4}", customer.Acc_name, customer.Acc_Number, customer.Address, customer.Account_Type, customer.Balance);
                }
                //sw.Flush();
                //sw.Close();
            }
            sw.Flush();
            sw.Close();
        }
        public class Employee
        {
            public int id
            {
                get; set;
            }
            public string name
            {
                get;
                set;
            }
            public string Gender
            {
                get;
                set;
            }
            public double salary
            {
                get;
                set;
            }
        }
        public class Customer
        {
            public string Acc_name
            {
                get; set;
            }
            public int Acc_Number
            {
                get;
                set;
            }
            public string Address
            {
                get;
                set;
            }
            public int Account_Type
            {
                get;
                set;
            }
            public int Balance
            {
                get; set;
            }
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                int choice_selected;
                String ch;
                Bank bank = new Bank();
                AccountDeposit accDep = new AccountDeposit(bank.Savings_Account);
                for (; ; )
                {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("Welcome to Bank Application");
                    Console.WriteLine("********************");
                    Console.WriteLine("Enter any one number to proceed further : \n 1. Savings Account\n 2. Current Account\n 3. ChildCare Account\n 4. Display Employee List(Static)\n 5. Create Account(Dynamic)\n 6. Exit");
                    Console.WriteLine("******************");
                    ch = Console.ReadLine();

                    switch (ch)
                    {
                        case "1":
                            accDep();
                            break;
                        case "2":
                            accDep += bank.Current_Account;
                            accDep();
                            break;
                        case "3":
                            accDep += bank.ChildCare_Account;
                            accDep();
                            break;
                        case "4":
                            bank.DisplayCustomerDetails();
                            break;
                        case "5":
                            bank.CreateAccount();
                            break;
                        case "6":
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
