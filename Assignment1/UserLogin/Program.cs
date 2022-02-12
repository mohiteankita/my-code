using System;

namespace UserLogin
{
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }

    class Login
    {
            public void PassValidation(string uid, string pwd)
            {
                char[] pass = pwd.ToCharArray();
                bool special_char = false, digit = false;

                for(int i=0; i<pass.Length; i++)
                {
                    if(pass[i] >= 48 && pass[i] <= 57)
                    {
                        digit = true;
                    }
                    if(!((pass[i]>=65 && pass[i]<=90) || (pass[i]>=97 && pass[i]<=122 || (pass[i]>=48 && pass[i]<= 57))))
                    {
                        special_char = true;
                    }
                }

                if(pass.Length >=8 && special_char==true && digit==true)
                {
                    Console.WriteLine("Login Successful");
                }
                else
                {
                    throw new InvalidPasswordException("The password should be 8 digit containing one digit and one special symbol");
                }
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Id: ");
            string uid = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string pwd = Console.ReadLine();

            Login login_obj = new Login();
            try
            {
                login_obj.PassValidation(uid, pwd);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
