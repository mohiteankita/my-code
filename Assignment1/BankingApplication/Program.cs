using System;

namespace BankingApplication
{
    class Bank
    {
        string customer_name, address;
        long account_number, contact_number;
        double initial_balance;
        int rate_of_interest;

        public Bank() { }
      
        public void CreateAccount(string customer_name, string address, long contact_number, long account_number, double initial_balance)
        {
            this.customer_name = customer_name;
            this.address = address;
            this.account_number = account_number;
            this.contact_number = contact_number;
            this.initial_balance = initial_balance;
        }

        public void Deposit(double deposit_amount)
        {
            initial_balance += deposit_amount;
            Console.WriteLine("Deposited " + deposit_amount + " Rs. Your Available Balance is Rs." + initial_balance);
        }

        public void Withdraw(double withdraw_amount)
        {
            initial_balance -= withdraw_amount;
            Console.WriteLine("Withdrawn " + withdraw_amount + " Rs. Your Available Balance is Rs." + initial_balance);
        }

        public void CompountInterest(float rate_of_interest, float time_period)
        {
            double amount = initial_balance * Math.Pow(((100 + rate_of_interest) / 100), time_period);
            double compound_interest = amount - initial_balance;
            Console.WriteLine("Compund Interest After Year " + time_period + " is Rs." + compound_interest);
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Your Available Balance is Rs." + initial_balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char conti;
            int choice;
            string customer_name, address;
            long account_number, contact_number;
            double initial_balance;
            float rate_of_interest;
            Bank bank_obj = new Bank();

            try
            {
                do
                {
                    Console.WriteLine("1.Create Account");
                    Console.WriteLine("2.Deposit Amount");
                    Console.WriteLine("3.Withdraw Amount");
                    Console.WriteLine("4.Calculate Compound Interest");
                    Console.WriteLine("5.Display Balance");

                    Console.WriteLine("Enter Your Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Customer Name: ");
                            customer_name = Console.ReadLine();
                            Console.WriteLine("Enter Address: ");
                            address = Console.ReadLine();
                            Console.WriteLine("Enter Contact Number: ");
                            contact_number = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter Account Number: ");
                            account_number = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter Initial Balance Amount: ");
                            initial_balance = double.Parse(Console.ReadLine());

                            bank_obj.CreateAccount(customer_name, address, contact_number, account_number, initial_balance);

                            break;

                        case 2:
                            Console.WriteLine("Enter Deposit Amount: ");
                            double deposit_amount = double.Parse(Console.ReadLine());

                            bank_obj.Deposit(deposit_amount);

                            break;

                        case 3:
                            Console.WriteLine("Enter Withdrawn Amount: ");
                            double withdraw_amount = double.Parse(Console.ReadLine());

                            bank_obj.Withdraw(withdraw_amount);

                            break;

                        case 4:
                            Console.WriteLine("Enter Rate of Interest: ");
                            rate_of_interest = float.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Time Period: ");
                            float time_period = float.Parse(Console.ReadLine());

                            bank_obj.CompountInterest(rate_of_interest, time_period);

                            break;

                        case 5:
                            bank_obj.DisplayBalance();
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                    Console.WriteLine("Do You Want To Continue Y/N: ");
                    conti = Convert.ToChar(Console.ReadLine());
                }
                while (conti == 'Y');
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank You!! Visit Again");
            }
        }
      
    }
}
