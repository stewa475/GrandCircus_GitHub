using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._2_RockPaperScissors
{
    class HulkHogan : Player
    {
        public HulkHogan(string name) : base(name)
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            roshambo = (Roshambo)random.Next(1, 4);
            return roshambo;
        }

    }
}
