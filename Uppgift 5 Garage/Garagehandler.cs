using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_5_Garage
{
    class Garagehandler
    {
        private Garage<Vehicle> garage1;

        public Garagehandler(int capacity)
        {
            garage1 = new Garage<Vehicle>(capacity);
        }

        public void ParkVehicle()
        {
           
            bool parking = true;
            while (parking == true)
            {   
                Console.WriteLine(
                    "Vehicle types you can park:\n" +
                    "Airplane\n" +
                    "Motorcycle\n" +
                    "Car\n" +
                    "Bus\n" +
                    "Boat\n" +
                    "Which type of Vehicle would you like to park?:");
                string switchin = Console.ReadLine().ToLower();
                switch (switchin)
                {

                    case "airplane":
                        Console.Clear();
                        string reg;
                        string color;
                        int wheel;
                        //var uniqueprop = ;
                        if (garage1.Add(new Airplane(reg = InputRegnumber(), color = InputColor(), wheel = InputWheelCount())))
                        { SuccessfulParking(reg, color, wheel, "Airplane"); }
                        else { Console.WriteLine("Failed to park"); }
                        parking = false;
                        break;
                    case "motorcycle":
                        Console.Clear();
                        if (garage1.Add(new Motorcycle(reg = InputRegnumber(), color = InputColor(), wheel = InputWheelCount())))
                        { SuccessfulParking(reg, color, wheel, "Motorcycle"); }
                        else { Console.WriteLine("Failed to park"); }
                        parking = false;
                        break;
                    case "car":
                        Console.Clear();
                        if (garage1.Add(new Car(reg = InputRegnumber(), color = InputColor(), wheel = InputWheelCount())))
                        { SuccessfulParking(reg, color, wheel, "Car"); }
                        else { Console.WriteLine("Failed to park"); }
                        parking = false;
                        break;
                    case "bus":
                        Console.Clear();
                        if (garage1.Add(new Bus(reg = InputRegnumber(), color = InputColor(), wheel = InputWheelCount())))
                        { SuccessfulParking(reg, color, wheel, "Bus"); }
                        else { Console.WriteLine("Failed to park"); }
                        parking = false;
                        break;
                    case "boat":
                        Console.Clear();
                        if (garage1.Add(new Boat(reg = InputRegnumber(), color = InputColor(), wheel = InputWheelCount())))
                        { SuccessfulParking(reg, color, wheel, "Boat"); }
                        else { Console.WriteLine("Failed to park"); }
                        parking = false;
                        break;

                    default:
                        Console.WriteLine(
                            "Not a valid Vehicle for this Garage,\n " +
                            "try another more well coded garage\n" +
                            "or input a valid Vehicle.");
                        break;
                }
            }           
        }
        public void UnparkVehicle()
        {            
            Console.WriteLine("Which of these parked vehicles would you like to unpark?:");
            PrintRegNumber();
            tryagain:
            
            var input = Console.ReadLine();
            if( garage1.Remove(input)) 
            {
                Console.WriteLine($"Successfully removed {input}");                
            }
            if (input == "back")
            {                
            }
            else
            {
                Console.WriteLine("Your input don't seem to match any of these vehicles");
                goto tryagain;
            }
            

            
        }
        
        public void PrintAllVehicles()
        {
            foreach (var item in garage1)
            {
                if (item == null)
                {
                    Console.WriteLine("Vacant");
                }
                else
                {
                    Console.WriteLine($"Regnumber: {item.Regnmbr} Color: {item.Color} Wheelcount: {item.Wheelcount} Type: {item.Type}");
                }                
            }
        }
        public void PrintRegNumber()
        {
            foreach (var item in garage1)
            {
                if (item == null)
                {                    
                }
                else
                {
                    Console.WriteLine($"Regnumber: {item.Regnmbr}");
                }
            }
        }
        public void PrintVehicleTypes()
        {
            int plane = 0;
            int mc = 0;
            int car = 0;
            int bus = 0;
            int boat = 0;
            foreach (var item in garage1)
            {
                if (item == null) { break; }
                if (item.Type == "Airplane") { plane++; }
                if (item.Type == "Motorcycle") { mc++; }
                if (item.Type == "Car") { car++; }
                if (item.Type == "Bus") { bus++; }
                if (item.Type == "Boat") { boat++; }
            }
            if (plane != 0) { Console.WriteLine($"Planes: {plane}"); }
            if (mc != 0) { Console.WriteLine($"Motorcycles: {mc}"); }
            if (car != 0) { Console.WriteLine($"Cars: {car}"); }
            if (bus != 0) { Console.WriteLine($"Buses: {bus}"); }
            if (boat != 0) { Console.WriteLine($"Boats: {boat}"); }
        }
        public void DefaultParking() 
        {
            garage1.Add(new Airplane("ABC595", "brown", 3));
            garage1.Add(new Airplane("JUMBO", "white", 7));
            garage1.Add(new Motorcycle("HARLEY", "orange", 3));
            garage1.Add(new Motorcycle("CDC493", "green", 2));
            garage1.Add(new Car("DOG953", "beige", 4));
            garage1.Add(new Car("SNO883", "blue", 4));
            garage1.Add(new Bus("DUA221", "purple", 6));
            garage1.Add(new Bus("TOTORO", "golden", 12));
            garage1.Add(new Boat("045YUD", "yellow", 0));
            garage1.Add(new Boat("TBC555", "red", 0));
        }
        public void SuccessfulParking(string reg, string col, int wheel, string type)
        {
            Console.WriteLine(
                $"You have successfully parked a {type}\n" +
                $"With Registration number: {reg}\n" +
                $"Colored {col}\n" +
                $"A wheelcount of: {wheel}\n" +
                $"");
        }
        public string InputRegnumber()
        {
            tryagain:
            Console.WriteLine("Input a Register number no longer than 6 characters:");
            var input = Console.ReadLine().ToUpper();
            if (input == "")
            {
                Console.Clear();
                Console.WriteLine("Nothing was input, try inputing anything.");
                goto tryagain;
            }
            else if (input.Length > 6)
            {
                Console.WriteLine("Input was too long, try input something shorter.");
                goto tryagain;
            }
            else
            {                
                return input;                    
            }
        }
        public string InputColor()
        {
        tryagain:
            Console.WriteLine("Input a Color:");
            var input = Console.ReadLine();
            if (input == "")
            {
                Console.Clear();
                Console.WriteLine("Nothing was input, try inputing anything.");
                goto tryagain;
            }            
            else
            {
                return input;
            }
        }
        public int InputWheelCount()
        {
            tryagain:
            Console.WriteLine("Input the amount of wheels on the vehicle:");
            try
            {
                return int.Parse(Console.ReadLine());
            }            
            catch (Exception)
            {
                Console.WriteLine("Invalid input, try again.");
                goto tryagain;
            }            
        }
        public void ParkingType(string vehicletype,string uniqueproperty)
        {
            Console.Clear();
            string type = "Airplane";
            var reg = InputRegnumber();
            var color = InputColor();
            var wheel = InputWheelCount();
            //var uniqueprop = ;
            garage1.Add(new Airplane(reg, color, wheel));
            SuccessfulParking(reg, color, wheel, type);            
        }
    }

}
