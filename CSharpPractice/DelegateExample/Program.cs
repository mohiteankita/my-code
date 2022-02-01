using System;

namespace DelegateExample
{
    class Program
    {
        delegate void MathDelegate(int a, int b);

        public void Add(int x, int y)
        {
            Console.WriteLine("Addition is " + (x + y));
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine("Subtraction is " + (x - y));
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine("Multiplication is " + (x * y));
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine("Division is " + (x / y));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate md = new MathDelegate(p.Add);
            md += new MathDelegate(p.Subtract);
            md += new MathDelegate(p.Multiply);
            md += new MathDelegate(p.Divide);
            md(10, 5);
            md -= new MathDelegate(p.Divide);
            Console.WriteLine("After Removing Divide");
            md(15, 5);
        }
    }
}
