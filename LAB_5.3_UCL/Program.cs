using System;

namespace LAB_5._3_UCL
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
            cars.AddCar(new Car("Chevrolet", "Equinox", 2019, 23800));
            cars.AddCar(new Car("Honda", "Pilot", 2019, 31450));
            cars.AddCar(new Car("Ford", "Fusion", 2019, 24105));
            cars.AddCar(new UsedCar("Acura", "TL", 2013, 8000, 223090));
            cars.AddCar(new UsedCar("Dodge", "Charger", 2011, 13000, 118000));
            cars.AddCar(new UsedCar("Nissan", "Maxima", 2013, 10000, 275000));

            Console.WriteLine("=======================");
            Console.WriteLine("WELCOME TO ALOTTA CARS!");
            Console.WriteLine("=======================");

            do
            {
                string type;
                int input;
                bool worked;
                do
                {
                    Console.WriteLine("1. LIST OF ALL AVAILABLE CARS");
                    Console.WriteLine("2. SELL YOUR CAR!");
                    Console.WriteLine("3. BUY A CAR!");
                    Console.Write("What would you like to do?: ");
                    worked = int.TryParse(Console.ReadLine(), out input);
                    
                    if (input == 1)
                    {
                        cars.ViewCars();
                    }
                    else if (input == 2)
                    {
                        do
                        {
                            Console.Write("\nWhat type of car would you like to add? (New or Used): ");
                            type = Console.ReadLine().ToLower();
                            if (type == "new")
                            {
                                string newMake = GetString("Enter the make: ");
                                string newModel = GetString("What is the model of the car: ");
                                int newYear = GetInt("What is the year of the car: ");
                                double newPrice = GetDouble("What is the price of the car: ");

                                cars.AddCar(new Car(newMake, newModel, newYear, newPrice));
                            }
                            else if (type == "used")
                            {
                                string newMake = GetString("What is the make of the car: ");
                                string newModel = GetString("What is the model of the car: ");
                                int newYear = GetInt("What is the year of the car: ");
                                double newPrice = GetDouble("What is the price of the car: ");
                                double newMileage = GetDouble("What is the mileage of the car: ");

                                cars.AddCar(new UsedCar(newMake, newModel, newYear, newPrice, newMileage));
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter a valid input.");
                            }
                        } while (type != "new" && type != "used");

                    }
                    else if (input == 3)
                    {
                        string input1;
                        cars.ViewCars();
                        Console.WriteLine("Which car would you like to buy?");
                        Console.Write("Enter the vin: ");
                        input1 = Console.ReadLine();

                        for (int i = 0; i < cars.Cars.Count; i++)
                        {
                            if (cars.Cars[i].Vin == input1)
                            {
                                cars.RemoveCar(cars.Cars[i]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid input.\n");
                    }
                } while (worked != true || (input != 1 && input != 2 && input != 3));
            } while (RunAgain());
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
