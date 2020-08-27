using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    /*
     Create a “FuelTank” class that has
    
    properties “Capacity” and “Level” (both represent a value in litres). 
    
    Level should throw an exception below 0, 
    
    and be clamped at the capacity. Both should have private setters. 
    
    Add A BurnFuel(litres) method and a Fill(litres) method. 
    

     */
    public class FuelTank
    {
        private double _capacity;
        public double Capacity
        {
            get
            {
                return _capacity;
            }
            private set
            {
                if (value > 50)
                {
                    _capacity = 50;
                }
                _capacity = Math.Round(value, 2);
            }
        }
        private double _level;
        public double Level {
            get
            {
                return _level;
            } 
            private set
            { 
                if(value<0)
                {
                    throw new Exception("Oh BOIIII WE NEED HELP!!!! ");
                }
                _level = Math.Round(value, 2);
            } 
        }

        //    Write a default constructor that initializes capacity at 50L and level at 50L.
        public FuelTank()
        {
            Capacity = 50;//in litres
            Level = 50;// in litres
        }

        public FuelTank(double capacity, double level)
        {
            Capacity = capacity;//in litres
            Level = level;// in litres
        }

        public void BurnFuel(double litres)
        {
            Level -= litres;
        }

        public void Fill(double litres)
        {
            Capacity = litres;
        }
    }
}
