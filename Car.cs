using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    /*
     Make (Chevrolet, Nissan, Toyota)
     Model (Camry, Corolla, Cruze)
     Color (Red, Green, Blue, Black)
     Maximum Occupancy (Number of Seats)
     FuelEfficiency (Number of KM per Litre, can have decimals)

     TODOs:
     Odometer - object reference
     FuelTank - object reference.
     */
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int MaxOccupancy { get; set; }
        public double FuelEfficiency { get; set; } //km/Litre and can have decimal value
        public FuelTank CarTank { get; set; }
        public Odometer CarOdo { get; set; }

        //create a default construcor of a car.

        public Car()
        {
            Make = "Honda";
            Model = "Civic";
            Color = "Silver";
            MaxOccupancy = 5;
            FuelEfficiency = (7.8 / 100);
            CarTank = new FuelTank();
            CarOdo = new Odometer();
        }

        //Greedy constructor
        public Car(string make, string model, string color, int maxOccupancy, double fuelEfficiency, double capacity, double level, double odometer)
        {
            Make = make;
            Model = model;
            Color = color;
            MaxOccupancy = maxOccupancy;
            FuelEfficiency = fuelEfficiency; //Litres/Km
            CarTank = new FuelTank(capacity, level);
            CarOdo = new Odometer(odometer);
        }
        //A ToString() override that will output the format “A Blue Chevy Cruze with 60050KM on the odometer, that has enough fuel to travel 65KM.”

        public override string ToString()
        {
            return $"A {Color} {Make} {Model} with {CarOdo.Counter} km on the odometer. The current fuel level in the tank is {CarTank.Level} litres. The fuel tank capacity of this car to be filled is {CarTank.Capacity} This car has enough fuel to travel {Math.Round(CarTank.Level/FuelEfficiency,2)} km.";
        }

        //default drive have 10km
        public void Drive()
        {
            Drive(10);
        }

        public void Drive(double km)
        {
            CarTank.BurnFuel(FuelEfficiency * km);
            CarTank.Fill(FuelEfficiency * km);
            CarOdo.Increment(km);
        }
    }
}
