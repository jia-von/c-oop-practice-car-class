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
        public FuelTank CarTank { get; set; }
        public Odometer CarOdo { get; set; }
        public Motor CarMotor { get; set; }
        public Seat CarSeat { get; set; }

        //create a default construcor of a car.

        public Car()
        {
            Make = "Honda";
            Model = "Civic";
            Color = "Silver";
            //CarSeat = new Seat();
            CarTank = new FuelTank();
            CarOdo = new Odometer();
            CarMotor = new Motor();
        }

        //Greedy constructor
        public Car(/*string make, string model, string color,  double capacity, double level, double odometer, */int maxOccupancy)
        {
            //Make = make;
            //Model = model;
            //Color = color;
            //CarTank = new FuelTank(capacity, level);
            //CarOdo = new Odometer(odometer);
            CarSeat = new Seat(maxOccupancy);
        }
        //A ToString() override that will output the format “A Blue Chevy Cruze with 60050KM on the odometer, that has enough fuel to travel 65KM.”

        public override string ToString()
        {
            return $"This cat has {CarSeat.MaxOccupancy.Length} seats.";
            //The current fuel level in the tank is {CarTank.Level} litres. This car has enough fuel to travel {Math.Round(CarTank.Level/CarMotor.FuelEfficiency,2)} km.A {Color} {Make} {Model} with {CarSeat.MaxOccupancy.Length} seats.
        }

        //default drive have 10km
        public void Drive()
        {
            Drive(10);
        }

        public void Drive(double km)
        {
            CarTank.BurnFuel(CarMotor.FuelEfficiency * km);
            CarTank.Fill(CarMotor.FuelEfficiency * km);
            CarOdo.Increment(km);
        }
    }
}
