using System;

namespace LessBalanceExceptionEx
{
    class LessBalanceException : ApplicationException
    {
        public LessBalanceException(string message) : base(message)
        {

        }
    }

    class Account
    {
        public float minimum_balance = 1000;
        public string accholder_name;
        public long account_no;
        public double initial_balance;

        public Account() { }
        public Account(string accholder_name, long account_no, double initial_balance)
        {
            this.accholder_name = accholder_name;
            this.account_no = account_no;
            this.initial_balance = initial_balance;
        }

        public void Deposit(double deposit_amount)
        {
            initial_balance += deposit_amount;
            Console.WriteLine("Deposited Rs." + deposit_amount + " Your Available Balance is Rs." + initial_balance);
        }

        public void Withdraw(double withdraw_amount)
        {
            initial_balance -= withdraw_amount;
            
            if (initial_balance < minimum_balance)
            {
                initial_balance += withdraw_amount;
                throw new LessBalanceException("Withdrawn Amount " + withdraw_amount + " Rs.is Not Valid.");
            }
            else
            {
                Console.WriteLine("Withdrawn Rs." + withdraw_amount + " Your Available Balance is Rs." + initial_balance);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account[] obj = new Account[2];
                int i = 0;
                do
                {
                    Console.WriteLine("1.Open Account");
                    Console.WriteLine("2.Deposit Amount");
                    Console.WriteLine("3.Withdraw Amount");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("Enter Your Choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter account holder name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter account number: ");
                            long accno = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Enter Initial Balance Amount: ");
                            double balance = double.Parse(Console.ReadLine());
                            obj[i] = new Account(name, accno, balance);
                            i++;
                            break;

                        case 2:
                            Console.WriteLine("Enter account number to deposit amount: ");
                            long accno1 = Convert.ToInt64(Console.ReadLine());
                            int flag = 0;
                            for (int k = 0; k < i; k++)
                            {
                                if (accno1 == obj[k].account_no)
                                {
                                    Console.WriteLine("Enter deposit amount: ");
                                    double deposit_amt = double.Parse(Console.ReadLine());
                                    obj[k].Deposit(deposit_amt);
                                    flag = 1;
                                }
                                
                            }
                            if(flag == 0)
                            {
                                  Console.WriteLine("Invalid Account Number");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter account number to withdraw amount: ");
                            long accno2 = Convert.ToInt64(Console.ReadLine());
                            int flag1 = 0;
                            for (int k = 0; k < i; k++)
                            {
                                if (accno2 == obj[k].account_no)
                                {
                                    Console.WriteLine("Enter withdrawn amount: ");
                                    double withdrawn_amt = double.Parse(Console.ReadLine());
                                    obj[k].Withdraw(withdrawn_amt);
                                    flag1 = 1;
                                }
                            }
                            if (flag1 == 0)
                            {
                                Console.WriteLine("Invalid Account Number");
                            }
                            break;

                        case 4:
                            Environment.Exit(1);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                while (true);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         }
    }
}
