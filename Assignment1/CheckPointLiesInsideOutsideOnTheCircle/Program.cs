using System;

namespace CheckPointLiesInsideOutsideOnTheCircle
{
    class Program
    {
        public void Circle()
        {
            Console.WriteLine("Enter the radius of circle: ");
            float radius = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the (x, y) co-ordinates of the point for checking it's position: ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());

            if(radius > Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.WriteLine("The point lie inside the circle");
            }
            else if(radius == Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                Console.WriteLine("The point lie on the circle");
            }
            else
            {
                Console.WriteLine("The point lie outside the circle");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Circle();
        }
    }
}
