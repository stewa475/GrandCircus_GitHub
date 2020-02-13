using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._2_RockPaperScissors
{
    class DwayneJohnson : Player
    {
        public DwayneJohnson(string name) : base(name)
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            roshambo = Roshambo.Rock;
            return roshambo;
        }

    }
}
