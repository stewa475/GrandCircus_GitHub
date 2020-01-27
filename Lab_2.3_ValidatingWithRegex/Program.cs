using System;
using System.Text.RegularExpressions;

namespace Lab_2._3_ValidatingWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string cont = "y";

            while (true)
            {
                Console.Write("Please enter your name: ");
                string name = Console.ReadLine();

                string patternName = @"^[A-z][A-Za-z]{0,29}$";

                if (Regex.IsMatch(name, patternName))
                {
                    Console.WriteLine("Name Valid!");
                }
                else
                {
                    Console.WriteLine("Name Invalid!");
                }

                Console.Write("Please enter your email: ");
                string email = Console.ReadLine();

                string patternEmail = @"^([A-z\d\.-]{5,30})@[A-Za-z]{5,10}[.](([A-za-z]{2,3})|([A-za-z]{2}\.[A-za-z]{2,3}))$";

                if (Regex.IsMatch(email, patternEmail))
                {
                    Console.WriteLine("Email Valid!");
                }
                else
                {
                    Console.WriteLine("Email Invalid!");
                }

                Console.Write("Please enter your phone number xxx-xxx-xxxx: ");
                string phone = Console.ReadLine();

                string patternPhone = @"^([1-9]{1}[\d]{2})[-][\d]{3}[-][\d]{4}$";

                if (Regex.IsMatch(phone, patternPhone))
                {
                    Console.WriteLine("Phone Valid!");
                }
                else
                {
                    Console.WriteLine("Phone Invalid!");
                }

                Console.Write("Please enter a Date dd/mm/yyyy: ");
                string date = Console.ReadLine();

                string patternDate = @"^(3[0-1]|2[0-9]|1[0-9]|0[1-9])\/(0[1-9]|1[0-2])\/[0-9]{4}$";

                if (Regex.IsMatch(date, patternDate))
                {
                    Console.WriteLine("Date Valid!");
                }
                else
                {
                    Console.WriteLine("Date Invalid!");
                }

                do
                {
                    Console.Write("Would you like to continue? (y/n): ");
                    cont = Console.ReadLine();

                    if (cont == "n" || cont == "N")
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }

                } while (cont != "y");

            }
        }
    }
}
