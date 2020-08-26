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

        //default drive have 10km
        public void Drive()
        {
            Drive(10);
        }

        public void Drive(double km)
        {
            double fuelUsed = FuelEfficiency * km;
            CarTank.BurnFuel(fuelUsed);
            CarTank.Fill(fuelUsed);
            CarOdo.Increment(km);
        }
    }
}
