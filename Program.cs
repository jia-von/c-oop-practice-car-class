using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car newCar = new Car();
            Console.WriteLine($"{newCar.CarOdo.Counter}");
            Console.WriteLine($"{newCar.CarTank.Level}");
            Console.WriteLine($"{newCar.Color}");
            newCar.Drive(23);
            Console.WriteLine($"{newCar.CarOdo.Counter}");
            Console.WriteLine($"{newCar.CarTank.Level}");
            Console.WriteLine($"{newCar.Color}");
        }
    }
}
