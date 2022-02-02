using System;
using System.Runtime.Serialization.Formatters.Soap;
namespace AccountDelegateEvent
{
    public class Account
    {
        string accno;
        string name;
        double balance;
        public delegate void AccountBalanceDelegate();
        public event AccountBalanceDelegate ShowMsg;
        public Account() { }
        public Account(string accno, string name, double balance)
        {
            this.accno = accno;
            this.name = name;
            this.balance = balance;
        }

        public override string ToString()
        {
            return "Account number= " + accno + ", Name= " + name + ", Available balance= " + balance;
        }

        public void Deposit(double bal)
        {
            balance += bal;
            Console.WriteLine("Available balance is Rs." + balance);
        }

        public void Withdraw(double bal)
        {
            if (bal > balance)
            {
                ShowMsg();
                
            }
            else
            {
                balance -= bal;
                Console.WriteLine("Available balance is Rs." + balance);
            }

        }
    }
    class Subscriber
    {
        public void PrintMsg()
        {
            Console.WriteLine("Please Enter Valid Amount!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("12022882", "Ankita", 25000);
            Subscriber s = new Subscriber();
            a.ShowMsg += new Account.AccountBalanceDelegate(s.PrintMsg);
            a.Deposit(2000);
            a.Withdraw(20000);
            //a.Withdraw(8000);
            Console.ReadLine();
        }
    }
}
