using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public abstract class Character : IComparable<Character>
    {
        private int _roundDamage;

        public virtual int RoundDamage
        {
            get 
            {
                Console.WriteLine($"{this.GetType().Name} {Name} zaatakował z siłą {Damage}");
                return Damage; 
            }

        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int CurrentLifePoints { get; set; }
        public int MaxLifePoints { get; set; }
        public int Damage { get; set; }
        public int Resistance { get; set; }

        public Character(string name, int level, int experience, int strength, int agility, int intelligence, int currentLifePoints, int maxLifePoints, int damage, int resistance)
        {
            Name = name;
            Level = level;
            Experience = experience;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            CurrentLifePoints = currentLifePoints;
            MaxLifePoints = maxLifePoints;
            Damage = damage;
            Resistance = resistance;
        }
        public Character() { }

        public virtual string ToString() =>  $"Name:{Name}, Level:{Level}, Experience:{Experience}, Strength:{Strength}," +
                                          $" Agility:{Agility}, Intelligence:{Intelligence}, Current Life Points:{CurrentLifePoints}," +
                                          $" MaxLifePoints:{MaxLifePoints}, Damage:{Damage}, Resistance:{Resistance}, ";

        public virtual bool Equals(object obj) => base.ToString().Equals(obj.ToString());

        public virtual int HashCode() => base.ToString().GetHashCode();

        public void UpgradeResistance(int armor) => Resistance += armor;

        public void UpgradeDamage(int damage) => Damage += damage;

        public virtual void GetHit(int hit)
        {
            if (Resistance < hit)
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

        public abstract void LevelUp();

        public int CompareTo(Character other) => Level.CompareTo(other.Level);
    }
}
