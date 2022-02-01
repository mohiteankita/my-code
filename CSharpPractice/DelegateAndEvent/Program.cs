using System;

namespace DelegateAndEvent
{

    class Program
    {
            public delegate string MyDel(string str);
            event MyDel MyEvent;

            public Program()
            {
                this.MyEvent += new MyDel(this.WelcomeUser);
            }

            public string WelcomeUser(string username)
            {
                return "Welcome" + username;
            }
        }
        static void Main(string[] args)
        {
                 
          
        }
}
