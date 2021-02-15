using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_5_Garage
{
    class Airplane : Vehicle
    {        
        public Airplane(string regnmbr, string color, int wheelcount) : base(regnmbr, color, wheelcount)
        {
            Type = "Airplane";
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(string regnmbr, string color, int wheelcount) : base(regnmbr, color, wheelcount)
        {
            Type = "Motorcycle";
        }
    }
    class Car : Vehicle
    {
        public Car(string regnmbr, string color, int wheelcount) : base(regnmbr, color, wheelcount)
        {
            Type = "Car";
            
        }
    }
    class Bus : Vehicle
    {
        public Bus(string regnmbr, string color, int wheelcount) : base(regnmbr, color, wheelcount)
        {
            Type = "Bus";
        }
    }
    class Boat : Vehicle
    {
        public Boat(string regnmbr, string color, int wheelcount) : base(regnmbr, color, wheelcount)
        {
            Type = "Boat";
        }
    }

}
