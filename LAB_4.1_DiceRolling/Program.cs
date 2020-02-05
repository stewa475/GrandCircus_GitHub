using System;

namespace LAB_4._1_DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            int sides;
            int roll1;
            int roll2;
            int count = 0;
            string exit;

            Console.WriteLine("Welcome to the Grand Circus Casino!");
            Console.WriteLine();

            Console.Write("How many sides should each die have?: ");
            sides = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            while (true)
            {
                roll1 = DiceRoll(sides);
                roll2 = DiceRoll(sides);

                count++;
                Console.WriteLine($"Roll {count}:");
                Console.WriteLine($"You rolled a {roll1} and a {roll2} ({roll1 + roll2} total)");
                if (sides == 6)
                {
                    DiceGame(roll1, roll2);
                }

                do
                {
                    Console.WriteLine();
                    Console.Write("Roll again? (y/n): ");
                    exit = Console.ReadLine().ToLower();

                    if (exit == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                    Console.WriteLine();
                } while (exit != "y");

            }
        }

        public static int DiceRoll(int sides)
        {
            Random random = new Random();
            return random.Next(1, sides + 1);
        }

        public static void DiceGame(int a, int b)
        {
            if (a == 1 && b == 1)
            {
                Console.WriteLine("Snake Eyes.");
            }
            if ((a == 1 && b == 2) || (a == 2 && b == 1))
            {
                Console.WriteLine("Ace Deuce.");
            }
            if (a == 6 && b == 6)
            {
                Console.WriteLine("Box Cars.");
            }
            if ((a + b == 7) || (a + b == 11))
            {
                Console.WriteLine("Win!");
            }
            if ((a + b == 2) || (a + b == 3) || (a + b == 12))
            {
                Console.WriteLine("Craps.");
            }
        }
    }
}
