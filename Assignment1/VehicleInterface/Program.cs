using System;

namespace VehicleInterface
{
    interface Vehicle
    {
        public void NoOfWheels(int wheels);
    }

    class Bicycle : Vehicle
    {
        public void NoOfWheels(int wheels)
        {
            Console.WriteLine("Bicycle have " + wheels + " wheels");
        }
    }

    class Car : Vehicle
    {
        public void NoOfWheels(int wheels)
        {
            Console.WriteLine("Car have " + wheels + " wheels");
        }
    }

    class Bike : Vehicle
    {
        public void NoOfWheels(int wheels)
        {
            Console.WriteLine("Bike have " + wheels + " wheels");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of wheels of bicycle: ");
            int no_of_wheels = int.Parse(Console.ReadLine());
            Bicycle bicycle_obj = new Bicycle();
            bicycle_obj.NoOfWheels(no_of_wheels);

            Console.WriteLine("______________________________________________________________________");

            Console.WriteLine("Enter number of wheels of car: ");
            int no_of_wheels1 = int.Parse(Console.ReadLine());
            Car car_obj = new Car();
            car_obj.NoOfWheels(no_of_wheels1);

            Console.WriteLine("______________________________________________________________________");

            Console.WriteLine("Enter number of wheels of bike: ");
            int no_of_wheels2 = int.Parse(Console.ReadLine());
            Bike bike_obj = new Bike();
            bike_obj.NoOfWheels(no_of_wheels2);

            Console.WriteLine("______________________________________________________________________");
        }
    }
}
