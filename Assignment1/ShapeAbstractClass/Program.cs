using System;

namespace ShapeAbstractClass
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }

    class Circle : Shape
    {
        float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Circle= " + 3.14 * radius * radius);
        }
    }

    class Rectangle : Shape
    {
        float length, breadth;

        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Rectangle= " + length * breadth);
        }
    }

    class Program
    {
        public void Call(Shape s)
        {
            s.CalculateArea();
            Console.WriteLine("______________________________________________________________");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius of Circle: ");
            float radius = float.Parse(Console.ReadLine());

            Circle c = new Circle(radius);
            Program p = new Program();
            p.Call(c);

            Console.WriteLine("Enter Length of Rectangle: ");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Breadth of Rectangle: ");
            float breadth = float.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(length, breadth);
            p.Call(r);
        }
    }
}
