using System;
using System.Collections.Generic;

namespace POS_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inv = new Inventory();
            Receipt rec = new Receipt();
            List<Tuple<string, double, int>> orders = new List<Tuple<string, double, int>>();
            List<string> cart = new List<string>();
            List<Product> products = new List<Product>();
            products.Add(new Product("Good Burger", "Food", "9,001 calories", 17.99));
            products.Add(new Product("Double Good Burger", "Food", "18,002 calories", 35.98));
            products.Add(new Product("Triple Good Burger", "Food", "27,003 calories", 53.97));
            products.Add(new Product("Good Dog", "Food", "7,400 calories", 14.99));
            products.Add(new Product("Good Chickwich", "Food", "6,500 calories", 13.00));
            products.Add(new Product("Good Taco", "Food", "4,000 calories", 8.00));
            products.Add(new Product("Good Fries", "Food", "5,555 calories", 11.99));
            products.Add(new Product("Good Pickle", "Food", "2,000 calories", 4.00));
            products.Add(new Product("Good Chillie", "Food", "3,500 calories", 6.99));
            products.Add(new Product("Good Orange Soda", "Drink", "5,000 calories", 10.00));
            products.Add(new Product("Good Diet Orange Soda", "Drink", "4,999 calories", 10.00));
            products.Add(new Product("Good Beverage", "Drink", "5,000 calories", 10.00));
            products.Add(new Product("Good Shake", "Dessert", "10,000 calories", 20.00));
            products.Add(new Product("Good Pies", "Dessert", "8,000 calories", 16.00));

            foreach (Product p in products)
            {
                inv.AddProduct(p.Name, 120);
            }

            Console.WriteLine(@"           _,---.     _,.---._       _,.---._                     "); 
            Console.WriteLine(@"       _.='.'-,  \  ,-.' , -  `.   ,-.' , -  `.   _,..---._       "); 
            Console.WriteLine(@"      /==.'-     / /==/_,  ,  - \ /==/_,  ,  - \/==/,   -  \      "); 
            Console.WriteLine(@"     /==/ -   .-' |==|   .=.     |==|   .=.     |==|   _   _\     "); 
            Console.WriteLine(@"     |==|_   /_,-.|==|_ : ;=:  - |==|_ : ;=:  - |==|  .=.   |     "); 
            Console.WriteLine(@"     |==|  , \_.' )==| , '='     |==| , '='     |==|,|   | -|     "); 
            Console.WriteLine(@"     \==\-  ,    ( \==\ -    ,_ / \==\ -    ,_ /|==|  '='   /     "); 
            Console.WriteLine(@"      /==/ _  ,  /  '.='. -   .'   '.='. -   .' |==|-,   _`/      "); 
            Console.WriteLine(@"      `--`------'     `--`--''       `--`--''   `-.`.____.'       "); 
            Console.WriteLine(@"                                               _,---.      ,----.               ");
            Console.WriteLine(@"         _..---.  .--.-. .-.-. .-.,.---.   _.='.'-,  \  ,-.--` , \  .-.,.---.   ");
            Console.WriteLine(@"       .' .'.-. \/==/ -|/=/  |/==/  `   \ /==.'-     / |==|-  _.-` /==/  `   \  ");
            Console.WriteLine(@"      /==/- '=' /|==| ,||=| -|==|-, .=., /==/ -   .-'  |==|   `.-.|==|-, .=., | ");
            Console.WriteLine(@"      |==|-,   ' |==|- | =/  |==|   '='  /==|_   /_,-./==/_ ,    /|==|   '='  / ");
            Console.WriteLine(@"      |==|  .=. \|==|,  \/ - |==|- ,   .'|==|  , \_.' )==|    .-' |==|- ,   .'  ");
            Console.WriteLine(@"      /==/- '=' ,|==|-   ,   /==|_  . ,'.\==\-  ,    (|==|_  ,`-._|==|_  . ,'.  ");
            Console.WriteLine(@"      |==|   -   //==/ , _  .'/==/  /\ ,  )/==/ _  ,  //==/ ,     //==/  /\ ,  )");
            Console.WriteLine(@"      `-._`.___,' `--`..---'  `--`-`--`--' `--`------' `--`-----`` `--`-`--`--' ");

            do
            {
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("================== Welcome to Good Burger! Home of the Good Burger! ===================");
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("=-------------------------------------- MENU -----------------------------------------=");
                Console.WriteLine("=======================================================================================");
                Console.WriteLine("=----------- FOOD ------------------------- CALORIES ------------------- PRICE -------=");
                Console.WriteLine("=======================================================================================");

                int menuCount = 0; ;
                foreach (Product p in products)
                {
                    menuCount++;
                    Console.WriteLine($"{menuCount,4}. {p}");
                    //Console.WriteLine($"Quantity: {inv.Quantity}");
                    
                }
                Console.WriteLine("=======================================================================================");
                do
                {
                    int numinput = InputInt("\nWhat can I get you?: ");
                    string input = inv.SelectItem(numinput);
                    int num;
                    if (inv.Inv.ContainsKey(input))
                    {
                        num = InputInt("\nHow many do you want?: ");

                        inv.RemoveQuantity(input, num);
                        rec.AddToCart(input, num);
                        cart.Add(input);
                        Console.WriteLine($"\nAdding {num} {input}(s).");
                        double pr = 0;
                        for (int i = 0; i < products.Count; i++)
                        {
                            if (products[i].Name == input)
                            {
                                pr = products[i].Price;
                            }
                        }
                        orders.Add(Tuple.Create(input, pr, num));
                    }
                    else
                    {
                        Console.WriteLine("\nSorry, we don't have those.\n");
                    }
                } while (RunAgain("Can I get you anything else? (y/n): "));


                Console.WriteLine("Thanks for your order!");
                Console.WriteLine("Here's what you got:");
                cart.Sort();
                double subTotal = 0;
                for (int i = 0; i < orders.Count; i++)
                {
                    Console.WriteLine($"{orders[i].Item3}x {orders[i].Item1,-12}{(orders[i].Item2 * orders[i].Item3).ToString("C")}");
                    subTotal += (Math.Round(orders[i].Item2 * orders[i].Item3, 2));
                }

                Console.WriteLine($"\nYour total: {subTotal.ToString("C")}");
                Console.WriteLine("Have a GOOOOOOD Day!");

                Console.WriteLine(inv);
            } while (RunAgain("Actually would you like to order more?: "));

            

        }
        static int InputInt(string prompt)
        {
            Console.Write(prompt);
            //Input validation to make sure an int is entered
            bool isValid = int.TryParse(Console.ReadLine(), out int userInput);
            while (!isValid)
            {
                Console.Write("That is not a valid entry. Please enter an integer: ");
                isValid = int.TryParse(Console.ReadLine(), out userInput);
            }
            return userInput;
        }
        public static bool RunAgain(string prompt)
        {
            char c;
            do
            {
                Console.Write(prompt);
                c = Console.ReadKey().KeyChar;

                if (c == 'n' || c == 'N')
                {
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');
            return true;
        }
    }
}
