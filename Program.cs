using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car newCar = new Car()
            {
                Make = "Toyota",
                Model = "Corolla",
                Color = "Pink",
                MaxOccupancy = 5,
                FuelEfficiency = (7.8 / 100),
                CarTank = new FuelTank(),
                CarOdo = new Odometer(60000),
            };
            newCar.Drive(100);
            Console.WriteLine(newCar.ToString());
        }
    }
}
