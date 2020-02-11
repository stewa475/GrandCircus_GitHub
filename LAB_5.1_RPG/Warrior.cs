using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_5._1_RPG
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public Warrior(string name, int strength, int intelligence,string weaponType)
            : base (name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }

        public override string Play()
        {
            return base.Play() + $" | Weapon Type: {weaponType}\n";
        }
    }
}
