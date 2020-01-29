using System;

namespace LAB_3._1_StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] students = new string[]
            {
                "Andrew",
                "Brian",
                "Carter",
                "David",
                "Erik",
                "Frank",
                "Gabe",
                "Hunter",
                "Indigo",
                "Jim"
            };

            string[] candy = new string[]
            {
                "Apple",
                "Banana",
                "Chips",
                "Deer",
                "Elk",
                "Fries",
                "Gum",
                "Heath",
                "Ice Cream",
                "Jerky"
            };

            string[] title = new string[]
            {
                "Administrator",
                "Business Analyst",
                "Creative Director",
                "Director",
                "Executive",
                "Finance Manager",
                "Garbage Person",
                "House Cleaner",
                "Investigator",
                "Jump Rope Champ"
            };

            int input1 = 0;
            string input2;
            bool done = false;
            int exit =2;

            while (true)
            {
                while (!done)
                {
                    Console.WriteLine();
                    Console.Write("Which student would you like to know more about? (1-10, 11 to see a list): ");
                    done = int.TryParse(Console.ReadLine(), out input1);


                    if (done && input1 >= 1 && input1 <= 10)
                    {
                        Console.Write($"Student {input1} is {students[input1 - 1]}. ");
                        break;
                    }
                    else if (done && input1 == 11)
                    {
                        Console.WriteLine($"List of Students:");
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}.\t{students[i]}");
                        }
                        done = false;
                    }
                    else
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                        done = false;
                    }

                }

                while(exit == 2)
                {
                    done = false;
                    while (!done)
                    {
                        Console.WriteLine($"What would you like to know about { students[input1 - 1]}? (enter \"favorite candy\" or \"previous title\"): ");
                        input2 = Console.ReadLine().ToLower();

                        if (input2 == "favorite candy")
                        {
                            Console.WriteLine($"{students[input1 - 1]}'s favorite candy is {candy[input1 - 1]}. ");
                            break;
                        }
                        else if (input2 == "previous title")
                        {
                            Console.WriteLine($"{students[input1 - 1]}'s previous title was {title[input1 - 1]}. ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please try again.");
                            continue;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Would you like to:");
                    Console.WriteLine("Learn more about the current student? (press 1)");
                    Console.WriteLine("Learn more about another student? (press 2)");
                    Console.WriteLine("Quit? (press 3)");
                    Console.Write("Enter here: ");
                    exit = int.Parse(Console.ReadLine());

                    if (exit == 3)
                    {
                        Console.WriteLine("Goodbye!");
                        return;
                    }
                    else if (exit == 2)
                    {
                        break;
                    }
                    else if (exit == 1)
                    {
                        exit = 2;
                    }


                } 

            }

        }
    }
}
