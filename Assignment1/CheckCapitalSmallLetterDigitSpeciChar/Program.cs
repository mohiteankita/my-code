using System;

namespace CheckCapitalSmallLetterDigitSpeciChar
{
    class Program
    {
        public void Validation(char ch)
        {
            if(ch>=65 && ch<=90)
            {
                Console.WriteLine(ch + " is a capital letter");
            }
            else if(ch>=97 && ch<=122)
            {
                Console.WriteLine(ch + " is a small letter");
            }
            else if(ch>=48 && ch<=57)
            {
                Console.WriteLine(ch + " is a digit");
            }
            else
            {
                Console.WriteLine(ch + " is a special character");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Program p = new Program();
            p.Validation(ch);
        }
    }
}
