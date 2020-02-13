using System;
using System.Collections.Generic;

namespace LAB_5._3_Used_Car_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            // List
            // ------------
            // + dynamic size
            // + index based
            // - indexes change when remove


            //Dictionary
            // ------------
            // + key: int //having a unique identifier
            // - Not index-based

            //2D array
            // ------------
            // + maps to real lot
            // + goes from car to space and space to car really well
            // - fixed size
            // - logical count (extra steps O(n)  where list is O(1))


            CarLot cars = new CarLot();
            cars.AddCar(new Car(10001, "Chevrolet", "Equinox", 2019, 23800));
            cars.AddCar(new Car(10002,"Honda", "Pilot", 2019, 31450));
            cars.AddCar(new Car(10003,"Ford", "Fusion", 2019, 24105));
            cars.AddCar(new UsedCar(10004,"Acura", "TL", 2013, 8000, 223090));
            cars.AddCar(new UsedCar(10005,"Dodge", "Charger", 2011, 13000, 118000));
            cars.AddCar(new UsedCar(10005,"Nissan", "Maxima", 2013, 10000, 275000));

            Console.WriteLine("=======================");
            Console.WriteLine("WELCOME TO ALOTTA CARS!");
            Console.WriteLine("=======================");

            int input = GetInt("1. LIST OF ALL AVAILABLE CARS\n" +
                "2. SELL YOUR CAR!\n" +
                "3.BUY A CAR!" +
                "What would you like to do?: ");
            if (input == 1)
            {
                cars.ViewCars();
            }
            else if (input == 2)
            {
                Console.WriteLine("What type of car would you like to add? (New or Used): ");
                string type = Console.ReadLine().ToLower();
                if (type == "new")
                {
                    int newVin = GetInt("Enter vin number: ");
                    string newMake = GetString("Enter the make: ");
                    string newModel = GetString("What is the model of the car: ");
                    int newYear = GetInt("What is the year of the car: ");
                    double newPrice = GetDouble("What is the price of the car: ");

                    cars.AddCar(new Car(newVin, newMake, newModel, newYear, newPrice));
                }
                else if (type == "used")
                {
                    int newVin = GetInt("Enter vin number: ");
                    string newMake = GetString("What is the make of the car: ");
                    string newModel = GetString("What is the model of the car: ");
                    int newYear = GetInt("What is the year of the car: ");
                    double newPrice = GetDouble("What is the price of the car: ");
                    double newMileage = GetDouble("What is the mileage of the car: ");

                    cars.AddCar(new UsedCar(newVin, newMake, newModel, newYear, newPrice, newMileage));
                }
            }
            else if (input == 3)
            {
                //Console.WriteLine("Which car would you like to buy?: ");
                //input1 = Console.ReadLine().ToLower();
                //cars.ViewCars(input1);
            }



        }
        public static string GetString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        public static double GetDouble(string prompt)
        {
            Console.Write(prompt);
            return double.Parse(Console.ReadLine());
        }
        public static bool RunAgain()
        {
            char c;
            do
            {
                Console.Write("\nWould you like to continue? (y/n): ");
                c = Console.ReadKey().KeyChar;

                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\n\nBye!\n");
                    return false;
                }
                Console.WriteLine("\n");
            } while (c != 'y' && c != 'Y');
            return true;
        }
    }
}
