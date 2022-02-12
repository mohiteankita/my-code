using System;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        public void ChooseChoice()
        {
            int choice;
            char conti;
            
            do
            { 
                Console.WriteLine("1.Print the received input");
                Console.WriteLine("2.Reverse");
                Console.WriteLine("3.Show last 3 values");
                Console.WriteLine("4.Show 2nd value");
                Console.WriteLine("5.Sort in ascending order");
                Console.WriteLine("6.Show top 2 values");
                Console.WriteLine("7.Show values with vowels only");
                Console.WriteLine("8.Show duplicate values if they exist");
                Console.WriteLine("9.Exit");

                Console.WriteLine("Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Received Input: ");
                        string[] name = ReadFileAndStoreInArray();
                        foreach (string n in name)
                        {
                            Console.WriteLine(n);
                        }
                        break;

                    case 2:
                        string[] name1 = ReadFileAndStoreInArray();
                        Array.Reverse(name1);
                        Console.WriteLine("Reverse Input");
                        foreach (string n in name1)
                        {
                            Console.WriteLine(n);
                        }
                        break;

                    case 3:
                        string[] name2 = ReadFileAndStoreInArray();
                        Console.WriteLine("Last 3 values: ");
                        for (int i = name2.Length - 1; i >= name2.Length - 3; i--)
                        {
                            Console.WriteLine(name2[i]);
                        }
                        break;

                    case 4:
                        string[] name3 = ReadFileAndStoreInArray();
                        Console.WriteLine("Second value: ");
                        Console.WriteLine(name3[1]);
                        break;

                    case 5:
                        Console.WriteLine("Values in ascending order: ");
                        string[] name4 = ReadFileAndStoreInArray();
                        for (int i = 0; i < name4.Length; i++)
                        {
                            string nme = name4[i].ToLower();
                            char[] chars = nme.ToCharArray();
                            char temp;
                            
                            for (int j = 0; j < chars.Length; j++)
                            {
                                for (int k = j + 1; k < chars.Length; k++)
                                {
                                    if (chars[j] > chars[k])
                                    {
                                        temp = chars[j];
                                        chars[j] = chars[k];
                                        chars[k] = temp;
                                    }
                                }
                            }
                            String str = new string(chars);
                            Console.WriteLine(str);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Top two values: ");
                        string[] name5 = ReadFileAndStoreInArray();
                        Console.WriteLine(name5[0] + "\n" + name5[1]);
                        break;

                    case 7:
                        Console.WriteLine("Values with vowels are: ");
                        string[] name6 = ReadFileAndStoreInArray();
                        for (int i = 0; i < name6.Length; i++)
                        {
                            int flag1 = 1;
                            string nme = name6[i];
                            for(int j=0; j<nme.Length; j++)
                            {
                                if(nme[j] == 'a' || nme[j] == 'e' || nme[j] == 'i' || nme[j] == 'o' || nme[j] == 'u' ||
                                 nme[j] == 'A' || nme[j] == 'E' || nme[j] == 'I' || nme[j] == 'O' || nme[j] == 'U')
                                {
                                    flag1 = 0;
                                }
                            }
                            if(flag1 == 0)
                            {
                                Console.WriteLine(nme);
                            }
                        }
                        break;

                    case 8:
                        int flag = 0;
                        Console.WriteLine("Duplicate values: ");
                        string[] name7 = ReadFileAndStoreInArray();
                        for (int i = 0; i < name7.Length; i++)
                        {
                            for (int j = i + 1; j < name7.Length; j++)
                            {
                                if (name7[i].Equals(name7[j]))
                                {
                                    Console.WriteLine(name7[i]);
                                    name7[j] = "++++";
                                    flag = 1;
                                }
                            }
                        }
                        if (flag == 0)
                        {
                            Console.WriteLine("No duplicate value found");
                        }
                        break;

                    case 9:
                        Console.WriteLine("Thank You!! Visit Again");
                        Environment.Exit(0);                       
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.WriteLine("Enter Y To Continue: ");
                conti = Convert.ToChar(Console.ReadLine());
            }
            while (conti == 'Y');

        }

        public string[] ReadFileAndStoreInArray()
        {
            FileStream fs = new FileStream("C:\\.Net\\Names.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fs);
            //Console.WriteLine(reader.ReadToEnd());

            string[] names = new string[15];

            for (int i = 0; i < 15; i++)
            {
                names[i] = reader.ReadLine();
            }

            return names;
        }

        //Validation of only characters are valid input
        public void CharAllowOnly()
        {
            string[] name = ReadFileAndStoreInArray();
            int flag = 0;
            for(int i=0; i<name.Length; i++)
            {
                string nme = name[i];
                Console.WriteLine(nme);
                for(int j=0; j<nme.Length; j++)
                {
                    if(!((nme[j] >=65 && nme[j] <= 90) || (nme[j] >= 97 && nme[j] <= 122)))
                    {
                        flag = 1;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Only characters are valid inputs");
            }
         
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ChooseChoice();
        }
    }
}
