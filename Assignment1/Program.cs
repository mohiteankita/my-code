using System;

namespace Assignment1
{
    class Program
    {
        public void CheckPallindromeString(string str)
        {
            string temp = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                temp += str[i];
            }
           
            if(str.Equals(temp.ToLower()))
            {
                Console.WriteLine("Pallindrome String");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome String");
            }
        }

        public void PallindromeNo(int no)
        {
            int x = no;
            string temp = "";
            while(no != 0)
            {
                temp += (no % 10);
                no /= 10;
            }
            int n = Convert.ToInt32(temp);
            Console.WriteLine(n);
            if (n == x)
            {
                Console.WriteLine("Pallindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome Number");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();

            new Program().CheckPallindromeString(str.ToLower());

            Console.WriteLine("Enter Number: ");
            int no = Convert.ToInt32(Console.ReadLine());
            new Program().PallindromeNo(no);
        }
    }
}
