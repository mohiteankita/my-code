using System;

namespace FibonacciSeries
{
    class Program
    {
        public void PrintFibonacciSeries()
        {
            int a = 0, b = 1, temp;
            
            for (int i=0; i<8; i++)
            {
                Console.Write(a + " ");
                temp = a + b;
                a = b;
                b = temp;
            }
        }
        static void Main(string[] args)
        {
            new Program().PrintFibonacciSeries();
        }
    }
}
