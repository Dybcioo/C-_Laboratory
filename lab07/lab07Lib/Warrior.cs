using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public class Warrior : Character
    {
        public int NumbersOfAttacks { get; set; }
        public override int RoundDamage
        {
            get 
            {
                Console.WriteLine($"{this.GetType().Name} {Name} zaatakował z siłą {Damage * NumbersOfAttacks}");
                return Damage * NumbersOfAttacks;
            }

        }

        public Warrior(string name, int level, int experience, int strength, int agility, int intelligence, int currentLifePoints, int maxLifePoints, int damage, int resistance, int numbersOfAttacks) :
            base(name, level, experience, strength, agility, intelligence, currentLifePoints, maxLifePoints, damage, resistance)
        {
            NumbersOfAttacks = numbersOfAttacks;
        }

        public Warrior(string name)
        {
            Name = name;
            Agility = 4;
            CurrentLifePoints = 100;
            Damage = 50;
            Experience = 0;
            Intelligence = 1;
            Level = 1;
            MaxLifePoints = 100;
            Resistance = 8;
            NumbersOfAttacks = 2;

            Strength = 8;
        }

        public override string ToString() => base.ToString() + $"Number Of Attacks:{NumbersOfAttacks}";
        public override void LevelUp()
        {
            Level += 1;
            Strength += 4;
            Damage += 25;
            MaxLifePoints += 50;
            CurrentLifePoints += 50;
            Resistance += 4;
            Intelligence += 1;
            Agility += 2;
            if(new Random().Next(5) == 1)
            {
                NumbersOfAttacks += 1;
            }
        }
    }
}
