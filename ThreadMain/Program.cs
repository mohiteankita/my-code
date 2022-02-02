using System;
using System.Threading;

namespace ThreadMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
        }
    }
}
