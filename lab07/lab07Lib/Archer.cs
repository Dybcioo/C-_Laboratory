using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public class Archer : Character
    {

        public int Dodge { get; set; }
        public Archer(string name, int level, int experience, int strength, int agility, int intelligence, int currentLifePoints, int maxLifePoints, int damage, int resistance, int dodge) : base(name, level, experience, strength, agility, intelligence, currentLifePoints, maxLifePoints, damage, resistance)
        {
            Dodge = dodge;
        }

        public Archer(string name)
        {
            Name = name;
            Agility = 10;
            CurrentLifePoints = 80;
            Damage = 400;
            Experience = 0;
            Intelligence = 4;
            Level = 1;
            MaxLifePoints = 80;
            Resistance = 5;
            Dodge = 3;
            Strength = 3;

        }

        public override string ToString() => base.ToString() + $"Dodge:{Dodge}";

        public override void GetHit(int hit)
        {
            int number = new Random().Next(1, 300);
            if (number > Dodge)
            {
                if(Resistance < hit)
            {
                    CurrentLifePoints -= Math.Abs(Resistance - hit);
                    if (CurrentLifePoints > 0)
                    {
                        Console.WriteLine($"{GetType().Name} {Name} został zraniony.. pozostała liczba życia {CurrentLifePoints}\n");
                    }
                    else
                    {
                        Console.WriteLine($"{GetType().Name} {Name} został zraniony.. i nie żyje\n");
                    }
                }
            else
                {
                    Console.WriteLine($" Atak za słaby aby {GetType().Name} {Name} został zraniony\n");
                }
            }
            else
            {
                Console.WriteLine($"{GetType().Name} {Name} uniknął ataku!\n");
            }

        }

        public override void LevelUp()
        {
            Agility += 5;
            Damage += 200;
            Intelligence += 2;
            Level += 1;
            MaxLifePoints += 50;
            CurrentLifePoints += 50;
            Resistance += 2;
            Dodge += 1;
            Strength += 1;
        }
    }
}
