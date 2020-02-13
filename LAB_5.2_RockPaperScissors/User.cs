using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._2_RockPaperScissors
{
    class User : Player
    {
        public User(string name) : base(name)
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            string input;
            do
            {
                Console.Write("\nEnter Rock, Paper, or Scissors: ");
                input = Console.ReadLine().ToLower();

                if (input == "rock")
                {

                    roshambo = Roshambo.Rock;
                    return roshambo;
                }
                else if (input == "paper")
                {
                    roshambo = Roshambo.Paper;
                    return roshambo;
                }
                else if (input == "scissors")
                {
                    roshambo = Roshambo.Scissors;
                    return roshambo;
                }
                Console.WriteLine("\nThat is not a valid entry");
            } while (true);
            
        }
    }
}
