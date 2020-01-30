using System;
using System.Collections;
using System.Collections.Generic;

namespace LAB_3._2_ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string order1;
            string again;
            List<string> shopList = new List<string>();

            Console.WriteLine("Welcome to Guenther's Market!");
            Console.WriteLine();
            Console.WriteLine(" Item\t\tPrice");
            Console.WriteLine("==============================");

            while (true)
            {
                Dictionary<string, double> inventory = new Dictionary<string, double>();
                inventory["apple"] = 0.99;
                inventory["banana"] = 0.59;
                inventory["cauliflower"] = 1.59;
                inventory["dragonfruit"] = 2.19;
                inventory["elderberry"] = 1.79;
                inventory["figs"] = 2.09;
                inventory["grapefruit"] = 1.99;
                inventory["honeydew"] = 3.49;

                foreach (KeyValuePair<string, double> kvPair in inventory)
                {
                    string cost = $"${kvPair.Value}";
                    Console.WriteLine($" {kvPair.Key,-12}{cost,8}");
                }
                Console.WriteLine();

                while (true)
                {
                    Console.Write("What item would you like to order?: ");
                    order1 = Console.ReadLine();

                    if (inventory.ContainsKey(order1))
                    {
                        shopList.Add(order1);
                        Console.WriteLine($"Adding {order1} to cart at ${inventory[order1]}");
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we don't have those. Please try again.");
                        Console.WriteLine();
                        continue;
                    }
                }

                do
                {
                    Console.Write("Would you like to order anything else? (y/n): ");
                    again = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    if (again == "n")
                    {
                        Console.WriteLine("Thanks for your order!");
                        Console.WriteLine("Here's what you got:");
                        shopList.Sort();
                        double sum = 0;
                        for (int i = 0; i < shopList.Count; i++)
                        {
                            Console.WriteLine($"{shopList[i],-12}${inventory[shopList[i]]}");
                            sum += inventory[shopList[i]];
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Your total: ${Math.Round(sum,2)}");
                        Console.WriteLine($"Average price per item: ${Math.Round(sum / shopList.Count, 2)}");
                        Console.WriteLine("Come again!");
                        return;
                    }

                } while (again != "y");
                
                

            }
            

        }
    }
}
