using System;
using System.Collections.Generic;

namespace LAB_5._1_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gc = new List<GameCharacter>();
            gc.Add(new Warrior("SoyLatte", 30, 5, "Club"));
            gc.Add(new Warrior("VanillaLatte", 25, 10, "Sword"));
            gc.Add(new Wizard("PumpkinSpiceLatte", 10, 25, 100, 3));
            gc.Add(new Wizard("CarmelCloud", 5, 30, 100, 3));

                Console.WriteLine("======== WELCOME TO COFFEE HEROS! ========");
                Console.WriteLine("------------------------------------------\n");
                foreach (GameCharacter g in gc)
                {
                    Console.WriteLine(g.Play());
                }
                Console.WriteLine("------------------------------------------\n");
        }
    }
}
