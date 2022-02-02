using System;

namespace StockManagementDelegateEvent
{
    class InsufficientItemException : ApplicationException
    {
       public InsufficientItemException(string message) : base(message)
        {

        }
    }
    class StockManagement
    {
        int item_bal;
        int reorder_bal = 100;
        public delegate void ReorderDelegate();
        public event ReorderDelegate ReOrderEvent;

        public StockManagement(int bal)
        {
            item_bal = bal;
        }

        public void Sell(int qty)
        {
            if(item_bal > qty)
            {
                item_bal -= qty;
                Console.WriteLine("Sold {0} balance is {1}", qty, item_bal);
                if(item_bal <= reorder_bal)
                {
                    ReOrderEvent();
                }
            }
            else
            {
                throw new InsufficientItemException(item_bal + " items are available in stock \nPlease enter valid choice");
            }
        }

        public void Purchase(int qty)
        {
            item_bal += qty;
            Console.WriteLine("Purchase {0} balance is {1}", qty, item_bal);
        }
    }

    class Notification
    {
        public void SendMail()
        {
            Console.WriteLine("Item balance is not sufficient please order new stock");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StockManagement obj = new StockManagement(1000);

                obj.ReOrderEvent += new StockManagement.ReorderDelegate(new Notification().SendMail);
                obj.Purchase(200);
                obj.Sell(600);
                obj.Sell(500);
                obj.Sell(800);
                
            }
            catch(InsufficientItemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
