using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._1_RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber)
            : base (name, strength, intelligence,magicalEnergy)
        {
            this.spellNumber = spellNumber;
        }

        public override string Play()
        {
            return base.Play() + $" | Spell Number: {spellNumber}\n";
        }
    }
}
