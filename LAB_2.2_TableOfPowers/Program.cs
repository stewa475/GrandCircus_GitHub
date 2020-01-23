using System;

namespace LAB_2._2_TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string done = "y";
            while (done == "y")
            {
                Console.Write("Enter an integer: ");
                int num = int.Parse(Console.ReadLine());
                if (num <= 0 || num > 1290)
                {
                    continue;
                }
                else
                {
                    Console.Write("Number\t\tSquared\t\tCubed");
                    Console.WriteLine();
                    Console.Write("=======\t\t========\t========");
                    Console.WriteLine();
                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write($"{i,7}");
                        Console.Write($"\t\t {Math.Pow(i,2),7}");
                        Console.Write($"\t {Math.Pow(i, 3),7}");
                        Console.WriteLine();
                    }
                    Console.Write("Continue? (y/n): ");
                    done = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
