using System;
using System.Collections.Generic;
using System.Linq;

namespace lab07
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Warrior("Wojowniczek"));
            characters.Add(new Mage("Magik"));
            characters.Add(new Archer("Strzelec"));

            characters[0].LevelUp();

            characters.Sort();
            characters.ForEach(c => Console.WriteLine(c.ToString() + "\n===================="));

            Dragon dragon = new Dragon()
            {
                Name = "Smok",
                Agility = 120,
                CurrentLifePoints = 99999,
                Damage = 230,
                Experience = 0,
                Intelligence = 101,
                Level = 100,
                MaxLifePoints = 99999,
                Resistance = 10000,
                ActualManaPoints = 1000,
                MaxManaPoints = 1000,
                Strength = 333,
            };
            dragon.OnDone += x => characters.ForEach(
                c => {
                    if (!c.IsDead())
                    {
                        c.GetHit(x);
                    }
                });
            characters.ForEach(c => c.IncreseExp(3000));
            CharacterTeam.IncreseExp(characters[0], 1000000);
            CharacterTeam.IncreseExp(characters[1], 3000000);
            CharacterTeam.IncreseExp(characters[2], 1000000);

            characters.ForEach(c => Console.WriteLine(c.ToString() + "\n===================="));

            Console.WriteLine("FIGHT!!!");

            while(Program.round(ref characters, ref dragon)) 
            {
                Console.WriteLine($"Punkty życia smoczka ==> {dragon.CurrentLifePoints}");
            }

            characters.ForEach(c => Console.WriteLine(c.ToString() + "\n===================="));

            

            /*var noobs = characters.Where(c => c.Level > 1)
                .Select(c => new
                {
                    c.Name,
                    c.Level
                });
            noobs.ToList().ForEach(c => Console.WriteLine(c));*/

        }

        public static bool round(ref List<Character> characters, ref Dragon dragon)
        {
            int counter = 0;
            foreach(var c in characters)
            {
                if (!c.IsDead() && !dragon.IsDead())
                {
                    if (c is Mage)
                    {
                        dragon.GetHit(((Mage)c).CastSpell(100));
                    }
                    else
                    {
                        dragon.GetHit(c.RoundDamage);
                    }
                }
                else
                {
                    counter++;
                }
            }
            if(counter >= characters.Count)
            {
                Console.WriteLine("Wszystkie postacie nie żyją !!!");
                return false;
            }
            if (dragon.IsDead())
            {
                Console.WriteLine("Smok nie żyje !!!");
                return false;
            }
            else 
            {
                dragon.Fire();
                return true;
            }
            
        }
    }
}
