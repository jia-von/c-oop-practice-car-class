using System;

namespace CarPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Car newCar = new Car();
            newCar.Drive(123);
            Console.WriteLine(newCar.ToString());
        }
    }
}
