using System;
using System.Threading;

namespace LAB_5._2_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string opp;

            Console.WriteLine("=========================================================");
            Console.WriteLine(" WELCOME TO THE |:ROCK:|:PAPER:|:SCISSORS:| SMACKDOWN!!!!");
            Console.WriteLine("=========================================================");

            Console.Write("\nPlease enter your name: ");
            input = Console.ReadLine();

            User np = new User(input);
            do
            {
                do
                {
                    Console.WriteLine("\n------------------");
                    Console.WriteLine("DWAYNE JOHNSON");
                    Console.WriteLine("HULK HOGAN");
                    Console.WriteLine("------------------\n");
                    Console.Write("Who would you like to play against?: ");
                    opp = Console.ReadLine().ToLower();

                    if (opp == "dwayne johnson" || opp == "hulk hogan")
                    {
                        break;
                    }
                    Console.WriteLine("\nPlease enter one of the opponents.");
                } while (true);

                if (opp == "dwayne johnson")
                {
                    Console.Clear();
                    Console.WriteLine("\n - DWAYNE JOHNSON");
                    Console.WriteLine("\t\"I AM ABOUT TO ROCK YOUR WORLD!\"");
                }
                if (opp == "hulk hogan")
                {
                    Console.Clear();
                    Console.WriteLine("\n - HULK HOGAN");
                    Console.WriteLine("\t\"Whatcha gonna do, when Hulkamania runs wild on you!\"");
                }


                if (opp == "dwayne johnson")
                {
                    int result;
                    int npcount = 0;
                    int djcount = 0;
                    DwayneJohnson dj = new DwayneJohnson(opp);
                    do
                    {
                        result = CheckWinner(np.GenerateRoshambo(), dj.GenerateRoshambo());
                        if (result == 1)
                        {
                            Console.Clear();
                            npcount++;
                            Console.WriteLine("\nYOU WIN!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                            + $"{np.ToString()} SCORE: {npcount}\n\n\tVS\n {dj.ToString()} SCORE: {djcount}");
                        }
                        else if (result == 2)
                        {
                            Console.Clear();
                            djcount++;
                            Console.WriteLine("\nYOU LOSE!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                            + $"{np.ToString()} SCORE: {npcount}\n\n\tVS\n {dj.ToString()} SCORE: {djcount}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\nDRAW!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                            + $"{np.ToString()} SCORE: {npcount}\n\n\tVS\n {dj.ToString()} SCORE: {djcount}");
                        }

                        if (djcount == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\nYOU LOST!!!!");
                            Console.WriteLine("\n - DWAYNE JOHNSON");
                            Console.WriteLine("\t\"Eat healthier and go to the gym..Then come back.\"");
                            break;
                        }
                        else if (npcount == 2)
                        {
                            while (true)
                            {
                                for (int i = 10; i > 0; i--)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' YOU ARE VICTORIOUS!!\' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                }
                                break;
                            }
                            break;
                        }

                    } while (true);

                }
                else if (opp == "hulk hogan")
                {
                    int result;
                    int npcount = 0;
                    int hhcount = 0;
                    HulkHogan hh = new HulkHogan(opp);
                    do
                    {
                        result = CheckWinner(np.GenerateRoshambo(), hh.GenerateRoshambo());

                        if (result == 1)
                        {
                            Console.Clear();
                            npcount++;
                            Console.WriteLine("\nYOU WIN!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                                + $"\t{np.ToString()} SCORE: {npcount}\n\n\tVS\n\t{hh.ToString()} SCORE: {hhcount}");
                        }
                        else if (result == 2)
                        {
                            Console.Clear();
                            hhcount++;
                            Console.WriteLine("\nYOU LOSE!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                                + $"{np.ToString()} SCORE: {npcount}\n\n\tVS\n{hh.ToString()} SCORE: {hhcount}");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\nDRAW!");
                            Console.WriteLine($"\n================================\n\tTWO OUT OF THREE\n================================"
                                + $"\t{np.ToString()} SCORE: {npcount}\n\n\tVS\n\t{hh.ToString()} SCORE: {hhcount}");
                        }

                        if (hhcount == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("\nYOU LOST!!!!");
                            Console.WriteLine("\n - HULK HOGAN");
                            Console.WriteLine("\t\"Train. Say your prayers. Eat your vitamins.\"");
                            break;
                        }
                        else if (npcount == 2)
                        {
                            while (true)
                            {
                                for (int i = 10; i > 0; i--)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' YOU ARE VICTORIOUS!!\' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine("\' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Console.WriteLine(" \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \' \'");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                }
                                break;
                            }
                            break;
                        }

                    } while (true);
                }
                else
                {
                    Console.WriteLine("Please enter a valid opponent.");
                }
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
                Console.WriteLine("\n");
            } while (c != 'y' && c != 'Y');
            return true;
        }
        public static int CheckWinner(Roshambo p1, Roshambo p2)
        {
            do
            {
                if ((int)p1 == (int)p2)
                {
                    return 3;
                }
                else if ((int)p1 == 1)
                {
                    if ((int)p2 == 2)
                    {
                        return 2;
                    }
                    else if ((int)p2 == 3)
                    {
                        return 1;
                    }
                }
                else if ((int)p1 == 2)
                {
                    if ((int)p2 == 1)
                    {
                        return 1;
                    }
                    else if ((int)p2 == 3)
                    {
                        return 2;
                    }
                }
                else if ((int)p1 == 3)
                {
                    if ((int)p2 == 1)
                    {
                        return 2;
                    }
                    else if ((int)p2 == 2)
                    {
                        return 1;
                    }
                }
            } while (true);
        }
    }
}

