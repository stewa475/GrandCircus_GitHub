using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._2_RockPaperScissors
{
    abstract class Player
    {
        protected string name;
        protected Roshambo roshambo;

        public string Name { get => name; set => name = value; }
        public Roshambo Roshambo { get => roshambo; set => roshambo = value; }

        public Player(string name)
        {
            this.name = name;
        }

        public abstract Roshambo GenerateRoshambo();


        public override string ToString()
        {
            return 
                $"\n---------------------\n{name.ToUpper()}: {roshambo}\n---------------------";
        }

    }
}
