using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car newCar = new Car();
            Console.WriteLine($"{newCar.CarOdo.Counter}");
            Console.WriteLine($"{newCar.CarTank.Capacity}");
            Console.WriteLine($"{newCar.Color}");
        }
    }
}
