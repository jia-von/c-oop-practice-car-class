using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string make, string model, string color, int maxOccupancy, double fuelEfficiency, double capacity, double level, double odometer

            Car newCar = new Car("Toyota", "Corolla", "Black", 5, 0.1, 40, 37, 999999); //999999 - odomoeter KM

            Console.WriteLine(newCar.ToString());
            newCar.Drive(30);// drove 50 km
            Console.WriteLine(newCar.ToString());
        }
    }
}
