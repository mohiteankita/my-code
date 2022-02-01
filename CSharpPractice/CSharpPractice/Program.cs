using System;
using System.IO;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("D:\\New_folder\\MyDir"); 
            //Console.WriteLine("Directory Created Successfully");
            //Console.WriteLine(Directory.GetCreationTime("D:\\New_folder\\MyDir"));

            DirectoryInfo di = new DirectoryInfo("D:\\New_folder\\NewDir");
            if(di.Exists)
            {
                Console.WriteLine("Directory Exists");
            }
            else
            {
                di.Create();
                Console.WriteLine("Directory Created");
            }

            Console.WriteLine(di.FullName);
            Console.WriteLine(di.CreationTime);
            Console.WriteLine(di.LastAccessTime);
            di.CreateSubdirectory("Subdir");
            File.Create("D:\\New_folder\\NewDir\\DemoFile.txt");

            FileInfo fi = new FileInfo("D:\\New_folder\\NewDir\\Mock2.txt");
            if(fi.Exists)
            {
                Console.WriteLine(fi.FullName);
                Console.WriteLine(fi.Length);
                Console.WriteLine(fi.Extension);
                Console.WriteLine(fi.CreationTime);
            }
            else
            {
                fi.Create();
                Console.WriteLine("File Created");
            }

            FileInfo[] flist = di.GetFiles();
            foreach(FileInfo f in flist)
            {
                Console.WriteLine(f.FullName);
                Console.WriteLine(f.Length);
                Console.WriteLine(f.Extension);
                Console.WriteLine(f.CreationTime);
                Console.WriteLine("________________________________________________________");
            }

            DriveInfo di1 = new DriveInfo("D:\\");
            Console.WriteLine(di1.Name);
            Console.WriteLine(di1.DriveFormat);
            Console.WriteLine(di1.VolumeLabel);
            Console.WriteLine(di1.AvailableFreeSpace);

            Console.WriteLine(Path.GetDirectoryName("D:\\New_folder\\NewDir\\Mock2.txt"));
            Console.WriteLine(Path.GetFileName("D:\\New_folder\\NewDir\\Mock2.txt"));
            Console.WriteLine(Path.GetExtension("D:\\New_folder\\NewDir\\Mock2.txt"));
            Console.WriteLine(Path.DirectorySeparatorChar);
        }
    }
}
