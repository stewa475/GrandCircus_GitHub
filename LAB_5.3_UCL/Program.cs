using System;
using System.Threading;

namespace LAB_5._3_UCL
{
    class Program
    {
        static void Main(string[] args)
        {

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
                    Console.WriteLine("1. LIST OF ALL AVAILABLE CARS FOR SALE");
                    Console.WriteLine("2. SELL YOUR CAR!");
                    Console.WriteLine("3. BUY A CAR!");
                    Console.Write("What would you like to do?: ");
                    worked = int.TryParse(Console.ReadLine(), out input);

                    if (input == 1)
                    {
                        Console.Clear();
                        cars.ViewCars();
                        Console.WriteLine("\nWe have the finest selection of top-of-the-line vehicles, please, take a look around.");
                    }
                    else if (input == 2)
                    {
                        do
                        {
                            Console.Write("\nIs your car new or used?: ");
                            type = Console.ReadLine().ToLower();
                            if (type == "new")
                            {
                                string newMake = GetString("Enter the make: ");
                                string newModel = GetString("Enter the model: ");
                                int newYear = GetInt("Enter the year: ");
                                double newPrice = GetDouble("Price you would like to sell for: ");
                                string decision = "";
                                while (decision != "y")
                                {
                                    Console.Write($"\nHow about ${(newPrice * .95):N2}? (y/n): ");
                                    decision = Console.ReadLine().ToLower();
                                    if (decision == "n")
                                    {
                                        for (int i = 50; i > 0; i -= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\\     \\      |                  |\n" +
                                                              " \\     \\     |                  |\n" +
                                                              "  \\     \\    |    ||    ||      |\n" +
                                                              "   \\     \\   |    ||    ||      |\n" +
                                                              "    \\     \\  |    ||    ||      |\n" +
                                                              "     \\     \\ |                  |\n" +
                                                              "      \\     \\|   |        |     |\n" +
                                                              "       \\     |   \\________/     |\n" +
                                                              "        \\    |                  |\n" +
                                                              "         \\   |                  |\n" +
                                                              "          \\  |                  |\n" +
                                                              "           \\ |                  |\n" +
                                                              "            \\|                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n");
                                            Console.WriteLine("\nThank you and please visit again!");
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            Console.WriteLine("|                  |      /     /\n" +
                                                          "|                  |     /     /\n" +
                                                          "|    ||    ||      |    /     /\n" +
                                                          "|    ||    ||      |   /     /\n" +
                                                          "|    ||    ||      |  /     /\n" +
                                                          "|                  | /     / \n" +
                                                          "|    |       |     |/     /\n" +
                                                          "|    \\_______/     |     /\n" +
                                                          "|                  |    /\n" +
                                                         "|                  |   /\n" +
                                                         "|                  |  /\n" +
                                                         "|                  | /\n" +
                                                         "|                  |/\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n");
                                            Console.WriteLine("\nThank you and please visit again!");
                                            Thread.Sleep(1000);
                                        }
                                        return;
                                    }
                                }
                                cars.AddCar(new Car(newMake, newModel, newYear, newPrice));
                                Console.Clear();
                                Console.WriteLine("\nCONGRATULATIONS!!");
                                Console.WriteLine($"You have sold your {newYear} {newMake} {newModel} for ${newPrice * .95:N2}");
                            }
                            else if (type == "used")
                            {
                                string newMake = GetString("Enter the make: ");
                                string newModel = GetString("Enter the model: ");
                                int newYear = GetInt("Enter the year: ");
                                double newMileage = GetDouble("Enter the mileage: ");
                                double newPrice = GetDouble("Price you would like to sell for: ");
                                string decision = "";
                                while (decision != "y")
                                {
                                    Console.Write($"\nHow about ${(newPrice * .8):N2}? (y/n): ");
                                    decision = Console.ReadLine().ToLower();
                                    if (decision == "n")
                                    {
                                        for (int i = 50; i > 0; i -= 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\\     \\      |                  |\n" +
                                                              " \\     \\     |                  |\n" +
                                                              "  \\     \\    |    ||    ||      |\n" +
                                                              "   \\     \\   |    ||    ||      |\n" +
                                                              "    \\     \\  |    ||    ||      |\n" +
                                                              "     \\     \\ |                  |\n" +
                                                              "      \\     \\|   |        |     |\n" +
                                                              "       \\     |   \\________/     |\n" +
                                                              "        \\    |                  |\n" +
                                                              "         \\   |                  |\n" +
                                                              "          \\  |                  |\n" +
                                                              "           \\ |                  |\n" +
                                                              "            \\|                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n" +
                                                              "             |                  |\n");
                                            Console.WriteLine("\nThank you and please visit again!");
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            Console.WriteLine("|                  |      /     /\n" +
                                                          "|                  |     /     /\n" +
                                                          "|    ||    ||      |    /     /\n" +
                                                          "|    ||    ||      |   /     /\n" +
                                                          "|    ||    ||      |  /     /\n" +
                                                          "|                  | /     / \n" +
                                                          "|    |       |     |/     /\n" +
                                                          "|    \\_______/     |     /\n" +
                                                          "|                  |    /\n" +
                                                         "|                  |   /\n" +
                                                         "|                  |  /\n" +
                                                         "|                  | /\n" +
                                                         "|                  |/\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n" +
                                                         "|                  |\n");
                                            Console.WriteLine("\nThank you and please visit again!");
                                            Thread.Sleep(1000);
                                        }
                                        return;
                                    }
                                }

                                cars.AddCar(new UsedCar(newMake, newModel, newYear, newPrice, newMileage));
                                Console.Clear();

                                Console.WriteLine("\nCONGRATULATIONS!!");
                                Console.WriteLine($"You have sold your {newYear} {newMake} {newModel} for ${newPrice * .8:N2}");
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
                        bool carBought = false;
                        Console.Clear();
                        cars.ViewCars();
                        Console.WriteLine("\nWhich car would you like to buy?");
                        do
                        {
                            Console.Write("Enter vin: ");
                            input1 = Console.ReadLine();

                            for (int i = 0; i < cars.Cars.Count; i++)
                            {
                                if (cars.Cars[i].Vin == input1)
                                {
                                    Console.Clear();
                                    Console.WriteLine("CONGRATULATIONS!!");
                                    Console.WriteLine($"You have purchased a {cars.Cars[i].Year} {cars.Cars[i].Make} {cars.Cars[i].Model} for ${cars.Cars[i].Price:N2}");
                                    cars.RemoveCar(cars.Cars[i]);
                                    carBought = true;
                                }
                            }
                            if (carBought == false)
                            {
                                Console.WriteLine("\nPlease enter a valid vin.");
                            }
                        } while (carBought == false);
                        
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

                    for (int i = 50; i > 0; i -= 2)
                    {
                        Console.Clear();
                        Console.WriteLine("\\     \\      |                  |\n" +
                                          " \\     \\     |                  |\n" +
                                          "  \\     \\    |    ||    ||      |\n" +
                                          "   \\     \\   |    ||    ||      |\n" +
                                          "    \\     \\  |    ||    ||      |\n" +
                                          "     \\     \\ |                  |\n" +
                                          "      \\     \\|   |        |     |\n" +
                                          "       \\     |   \\________/     |\n" +
                                          "        \\    |                  |\n" +
                                          "         \\   |                  |\n" +
                                          "          \\  |                  |\n" +
                                          "           \\ |                  |\n" +
                                          "            \\|                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n" +
                                          "             |                  |\n");
                        Console.WriteLine("\n\nBye!\n");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("|                  |      /     /\n" +
                                      "|                  |     /     /\n" +
                                      "|    ||    ||      |    /     /\n" +
                                      "|    ||    ||      |   /     /\n" +
                                      "|    ||    ||      |  /     /\n" +
                                      "|                  | /     / \n" +
                                      "|    |       |     |/     /\n" +
                                      "|    \\_______/     |     /\n" +
                                      "|                  |    /\n" +
                                     "|                  |   /\n" +
                                     "|                  |  /\n" +
                                     "|                  | /\n" +
                                     "|                  |/\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n" +
                                     "|                  |\n");
                        Console.WriteLine("\n\nBye!\n");
                        Thread.Sleep(1000);
                    }
                    return false;
                }
                Console.WriteLine("\n");
            } while (c != 'y' && c != 'Y');
            Console.Clear();
            return true;
        }
    }
}
