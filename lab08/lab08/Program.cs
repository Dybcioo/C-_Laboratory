using lab08lib;
using System;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            MageGuild mages = initializeGuild();
            //1mages.GetAllMages();
            //2mages.GetExpMages(50);
            //3mages.GetTalentedMages(80);
            //4mages.GetCommonPotential();
            //5mages.GetMagesSpells(3);
            //6mages.GetTheBestMages();
            //7mages.GetMageGreatestSpells();
            //8mages.GetAllSpells();
            //9mages.GetAllSpellsOfOneType(SpellType.defensive);
            //10mages.GetAllSpellsOfOneTypeAndOneMage(SpellType.offensive, "Chory królik");
            //11mages.GetNumberOfSpellsAllTypes();
            //12 mages.GetNumberOfSpellsAllTypesOneMage("Gandalf");
            //13mages.GetTheBestMagesWithoutGandalf();
            //14mages.GetAllReady();
            //15mages.isDead();
            mages.SpecialMission();
        }

        private static MageGuild initializeGuild()
        {
            MageGuild guild = new MageGuild();
            guild.AddMage(new Mage
            {
                Name = "Gandalf",
                Level = 100,
                Experience = 7000000,
                Strength = 15,
                Dextirity = 16,
                Inteligence = 21,
                HP = 0,
                MaxHP = 200,
                MP = 400,
                MaxMP = 400,
                Damage = 27,
                PhysicalResistance = 50,
                FireResistance = 50,
                IceResistance = 50,
                PoisonResistance = 50,
                SpellBook = new SpellBook
                {
                    new Spell { Name = "Fireball", SpellType= SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 75 },
                    new Spell { Name = "Light Ray", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 225 },
                    new Spell { Name = "Force Push", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 20 },
                    new Spell { Name = "Barrier", SpellType = SpellType.defensive, Cost = 20, Cooldown = 15, Effect = 10 },
                    new Spell { Name = "Mass Heal",SpellType = SpellType.restorative, Cost = 30, Cooldown = 8, Effect = 100 }
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Harry Potter",
                Level = 50,
                Experience = 1000000,
                Strength = 12,
                Dextirity = 14,
                Inteligence = 17,
                HP = 150,
                MaxHP = 150,
                MP = 250,
                MaxMP = 250,
                Damage = 15,
                PhysicalResistance = 10,
                FireResistance = 10,
                IceResistance = 10,
                PoisonResistance = 10,
                SpellBook = new SpellBook
                {
                    new Spell  { Name = "Fireball", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 75 },
                    new Spell { Name = "Barrier", SpellType = SpellType.defensive, Cost = 20, Cooldown = 15, Effect = 10 },
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Świrek muchomorek",
                Level = 70,
                Experience = 1000000,
                Strength = 8,
                Dextirity = 14,
                Inteligence = 17,
                HP = 150,
                MaxHP = 150,
                MP = 250,
                MaxMP = 250,
                Damage = 15,
                PhysicalResistance = 10,
                FireResistance = 10,
                IceResistance = 10,
                PoisonResistance = 10,
                SpellBook = new SpellBook
                {
                    new Spell { Name = "Fireball", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 75 },
                    new Spell { Name = "Light Ray", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 225 },
                }
            });
            guild.AddMage(new Mage
            {
                Name = "Chory królik",
                Level = 60,
                Experience = 1000000,
                Strength = 11,
                Dextirity = 14,
                Inteligence = 25,
                HP = 150,
                MaxHP = 150,
                MP = 250,
                MaxMP = 250,
                Damage = 15,
                PhysicalResistance = 10,
                FireResistance = 10,
                IceResistance = 10,
                PoisonResistance = 10,
                SpellBook = new SpellBook
                {
                    new Spell { Name = "Fireball", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 75 },
                    new Spell { Name = "Light Ray", SpellType = SpellType.offensive, Cost = 25, Cooldown = 10, Effect = 225 },
                }
            });
            return guild;
        }
    }
}
