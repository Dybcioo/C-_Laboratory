using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public class Mage : Character, ISpellCastable
    {
        public int ActualManaPoints { get; set; }
        public int MaxManaPoints { get; set; }
        public int CastSpell(int manaPoints)
        {
            if (ActualManaPoints - manaPoints < 0)
            {
                throw new NoManaException("Brak many!");
            }
            Console.WriteLine($"{this.GetType().Name} {Name} rzucił czar o sile {Damage * Intelligence}");
            ActualManaPoints -= manaPoints;
            return Intelligence * Damage;
        }

        public Mage(string name, int level, int experience, int strength, int agility, int intelligence, int currentLifePoints, int maxLifePoints, int damage, int resistance, int actualManaPoints, int maxManaPoints) : 
            base(name, level, experience, strength, agility, intelligence, currentLifePoints, maxLifePoints, damage, resistance)
        {
            ActualManaPoints = actualManaPoints;
            MaxManaPoints = maxManaPoints;
        }

        public Mage(string name)
        {
            Name = name;
            Agility = 7;
            CurrentLifePoints = 50;
            Damage = 3;
            Experience = 0;
            Intelligence = 10;
            Level = 1;
            MaxLifePoints = 100;
            Resistance = 5;
            ActualManaPoints = 50;
            MaxManaPoints = 100;
            Strength = 2;
        }

        public override string ToString() => base.ToString() + $"Aktualna liczba many:{ActualManaPoints}, Maksymalna liczba many:{MaxManaPoints}";
        public override void LevelUp()
        {
            Agility += 3;
            Damage += 1;
            Intelligence += 5;
            Level += 1;
            MaxLifePoints += 50;
            CurrentLifePoints += 50;
            Resistance += 2;
            MaxManaPoints += 50;
            ActualManaPoints += 50;
            Strength += 1;
        }
    }
}
