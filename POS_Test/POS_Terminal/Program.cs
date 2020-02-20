using System;
using System.Collections.Generic;

namespace POS_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Good Burger, home of the Good Burger!");

            Inventory inv = new Inventory();
            Receipt rec = new Receipt();
            List<Product> products = new List<Product>();
            products.Add(new Product("Good Burger", "Food", "9001 calories", 17.99));
            products.Add(new Product("Orange Soda", "Drink", "5000 calories", 8.99));

            foreach (Product p in products)
            {
                inv.AddProduct(p.Name, 120);
            }

            foreach (Product p in products)
            {
                Console.WriteLine("===================");
                Console.WriteLine(p);
                Console.WriteLine($"Quantity: {inv.Quantity}");
                Console.WriteLine("===================");
            }

            Console.Write("Can I take your order?: ");
            string input = Console.ReadLine();

            Console.Write("How many do you want to buy?: ");
            int num = int.Parse(Console.ReadLine());

            inv.RemoveQuantity(input, num);

            rec.AddToCart(input, num);
            



            Console.WriteLine(inv);

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
            Console.Clear();
            return true;
        }
    }
}
