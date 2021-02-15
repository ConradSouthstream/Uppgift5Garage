using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Uppgift_5_Garage
{
    class Mainmenu
    {
        public static Garagehandler garaget;
        public static void SetupGarage()
        {
            Console.WriteLine(
                "How big of a Garage do you want to have?\n" +
                "(has to be at least 10 parking spots)");
            tryagain:
            try
            {
                Console.WriteLine("Size:");
                var input = int.Parse(Console.ReadLine());
                if (input >= 10)
                {
                    garaget = new Garagehandler(input);
                }
                else
                {
                    Console.WriteLine("Too small Garage, input at least 10");
                    goto tryagain;
                }
                
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid input, try again");
                goto tryagain;
            }
        }
        public static void NavigateMainMenu()
        {
            do
            {
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid menu choice");
                }
                switch (input)
                {
                    case '1':
                        
                        Console.Clear();
                        Mainmenu.garaget.PrintAllVehicles();
                        PrintMainMenu();
                        break;
                    case '2':
                        Console.Clear();
                        Mainmenu.garaget.PrintVehicleTypes();
                        PrintMainMenu();
                        break;
                    case '3':
                        Console.Clear();
                        Mainmenu.ParkOrUnpark();
                        PrintMainMenu();
                        break;
                    case '4':
                        Console.Clear();
                        Mainmenu.garaget.DefaultParking();
                        Console.WriteLine("10 Vehicles have been parked in the garage");
                        PrintMainMenu();
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (true);
           
        }
        public static void ParkOrUnpark()
        {
            bool status = true;
            do
            {
                Console.WriteLine(
               "what would you like to do?\n" +
               "1 to park\n" +
               "2 to unpark\n" +
               "3 to go back");
                char input = ' ';
                try
                {
                    input = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid menu choice");
                }
                switch (input)
                {
                    case '1':
                        Console.Clear();
                        garaget.ParkVehicle();
                        break;
                    case '2':
                        Console.Clear();
                        garaget.UnparkVehicle();
                        break;
                    case '3':
                        status = false;
                        break;

                }
            } while (status == true);
        }
        public static void PrintMainMenu()
        {
            Console.WriteLine(
                "Main menu choices:\n" +
                "1 List Vehicles in the garage\n" +
                "2 List Types of Vehicles and amount parked\n" +
                "3 add and remove Vehicles\n" +
                "4 Park some default Vehicles\n" +
                "5 Find a Vehicle with Registration Number\n" +
                "6 Find Vehicles with properties\n" +
                "0 Exit the Garage");
        }

    }
}
