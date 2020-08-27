using System;
using System.Collections.Generic;
using System.Text;

namespace CarPractice
{
    public class Seat
    {
        //Create a seat object with a boolean for whether it is occupied, and change maximum occupancy to an array of seats.
        public int[] MaxOccupancy { get; set; }
        //public Seat()
        //{
        //    bool[] seatArray = new bool[5]; // default 5 arrays 
        //    MaxOccupancy = seatArray;
        //}

        //public Seat(int x)
        //{
        //    int [] seatArray = new int[x];
        //    MaxOccupancy = seatArray;
        //}
        public Seat(int maxOccupancy)
        {
            int[] maxSeats = new int[maxOccupancy];
            MaxOccupancy = maxSeats;
        }
        }
    }

