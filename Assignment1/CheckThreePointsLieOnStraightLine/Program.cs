using System;

namespace CheckThreePointsLieOnStraightLine
{
   
    class Program
    {
        public void StraightLine()
        {
            Console.WriteLine("Enter the co-ordinates of first point (x1, y1): ");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the co-ordinates of second point (x2, y2): ");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the co-ordinates of third point (x3, y3): ");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            double ab = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
            double bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double ac = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

            double abc = ab + bc;
            if(abc == ac)
            {
                Console.WriteLine("All the three points fall on one straight line.");
            }
            else
            {
                Console.WriteLine("All the three points are not present on one straight line.");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.StraightLine();
        }
    }
}
