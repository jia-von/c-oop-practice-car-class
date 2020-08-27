using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string make, string model, string color, int maxOccupancy, double fuelEfficiency, double capacity, double level, double odometer

            Car newCar = new Car(7);

            Console.WriteLine(newCar.ToString());
           

        }
    }
}
