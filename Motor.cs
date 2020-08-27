using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    public class Motor
    {
        public double FuelEfficiency { get; set; } //km/Litre and can have decimal value
        public Motor()
        {
            FuelEfficiency = (7.8 / 100); //Default fuel efficiency
        }
        public Motor(double fuelEfficiency)
        {
            FuelEfficiency = fuelEfficiency; //Litres/Km
        }
    }
}
