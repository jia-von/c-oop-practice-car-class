using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    public class Odometer
    {
        /*
         Create a “Odometer” class that has a property “Counter” with a 
        
        getter and a private setter, 
        
         Perform reset validation in the counter’s setter, where if the new value would go over 999999, reset it to 0 and apply the excess (for example, 999980 + 40 = 000020). 
        
         */
        private double _counter;
        public double Counter { 
            get
            {
                return _counter;
            }
            private set
            {
                if(value> 999999)
                {
                    _counter = value - 999999;
                }
                _counter = value;
            }
            }

        //Write a default constructor that initializes the counter at 0.
        public Odometer()
        {
            Counter = 0;
        }

        public Odometer(double counter)
        {
            Counter = counter;
        }

        //and an Increment(count) method which will add the count to the counter.
        public void Increment(double counter)
        {
            Counter += counter;
        }
    }
}
