using System;

namespace LAB_2._1_RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string input = "y";
            while (input == "y")
            {
                Console.Write("Enter Length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("");

                double area = GetArea(length, width);
                double perimeter = GetPerimeter(length, width);
                double volume = GetVolume(length, width, height);

                Console.WriteLine($"Area: " + area + " square feet");
                Console.WriteLine($"Perimeter: " + perimeter+ " feet");
                Console.WriteLine($"Volume: " + volume + " feet cubed");

                if (area >= 650)
                {
                    Console.WriteLine("This is a large room!");
                }
                else if (area >= 250)
                {
                    Console.WriteLine("This is a medium sized room.");
                }
                else
                {
                    Console.WriteLine("This is a small room...");
                }
                Console.WriteLine("");
                Console.Write("Would you like to continue? (y/n): ");
                input = (Console.ReadLine().ToLower());
                Console.WriteLine("");
            }
            Console.WriteLine("Thank you for using the Room Detail Generator!");
        }
        static double GetArea(double length, double width)
        {
            double area = length * width;
            return area;
        }
        static double GetPerimeter(double length, double width)
        {
            double perimeter = (length * 2) + (width * 2);
            return perimeter;
        }
        static double GetVolume(double length, double width, double height)
        {
            double volume = length * width * height;
            return volume;
        }

    }
}
