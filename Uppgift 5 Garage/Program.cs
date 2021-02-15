using System;
using System.Collections.Generic;
using System.Linq;

namespace Uppgift_5_Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainmenu.SetupGarage();
            Mainmenu.PrintMainMenu();
            Mainmenu.NavigateMainMenu();
        }
        
    }
}
//Console.WriteLine("Oh my god");
//
//Garage<Vehicle> Garage1 = new Garage<Vehicle>(10);
//
//
////Garage1.Add(new Vehicle("DDD333",4));
//var fordonet = new Vehicle("DiD333", "blue", 4);
//Garage1.Add(new Vehicle("DDD333", "red", 4));
//Garage1.Add(fordonet);
//Garage1.Add(new Airplane("Taxi", "Yellow", 3));
//Garage1.Add(new Airplane("CBA321", "greeen", 5));
//Console.WriteLine(Garage1[0].Regnmbr);
//Console.WriteLine(Garage1[0].Regnmbr.Equals(Garage1[0].Regnmbr, StringComparison.OrdinalIgnoreCase));
//var annatgarage = new Garagehandler(10);
//annatgarage.ParkVehicle();
//foreach (var skrot in Garage1)
//{
//    if (skrot == null)
//    {
//        Console.WriteLine("null");
//    }
//    else
//    {
//        Console.WriteLine($"Regnumber: {skrot.Regnmbr} Color: {skrot.Color} Wheelcount: {skrot.Wheelcount}");
//    }
//
//}
//annatgarage.PrintAllVehicles();
////var fan = Garage1.
//Console.WriteLine("mmhmm");
//Console.WriteLine();
