using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_5_Garage
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Regnmbr { get; set; }
        public int Wheelcount { get; set; }
        public string Color { get; set; }

        public Vehicle(string regnmbr,string color, int wheelcount)
        {
            Regnmbr = regnmbr;
            Wheelcount = wheelcount;
            Color = color;
        }        
    }
}
