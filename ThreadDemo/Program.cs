using System;
using System.Threading;

namespace ThreadDemo
{
    class ThreadClass
    {
        public void ThreadMethod()
        {
            lock(this)
            {
                //Monitor.Enter(this);
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(System.Threading.Thread.CurrentThread.Name + "-" + i);
                    Thread.Sleep(200);
                }
                //Monitor.Exit(this);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass tc = new ThreadClass();
            ThreadStart ts1 = new ThreadStart(tc.ThreadMethod);
            Thread t1 = new Thread(ts1);
            t1.Name = "First Thread";
            t1.Start();

            ThreadStart ts2 = new ThreadStart(tc.ThreadMethod);
            Thread t2 = new Thread(ts2);
            t2.Name = "Second Thread";
            t2.Start();
        }
    }
}
