using System;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.WriteLine("Let's locate some primes!");
            do
            {
                Console.Write("\nWhich prime number number are you looking for?:  ");
                input = int.Parse(Console.ReadLine());

                if (input < 1)
                {
                    Console.WriteLine("Bye!");
                    return;
                }

                Console.WriteLine($"\nThe number {input} prime is {PrimeNumbers.GetPrime(input)}.");
            } while (RunAgain());
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
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');
            return true;
        }
    }
}
