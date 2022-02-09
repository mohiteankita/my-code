using System;

namespace RectangleClassUseOfOut
{
    class Rectangle
    {
        public void Calculate(float length, float breadth, out double area, out double perimeter)
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double area, perimeter;

            Console.WriteLine("Enter Length of Rectangle: ");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Rectangle: ");
            float breadth = float.Parse(Console.ReadLine());

            Rectangle r = new Rectangle();
            r.Calculate(length, breadth, out area, out perimeter);

            Console.WriteLine("Area of Rectangle= " + area + "\nPerimeter of Rectangle= " + perimeter);
        }
    }
}
