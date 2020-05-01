using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab08lib
{
    public partial class MageGuild : List<Mage>
    {

        public void GetAllMages() => this.OrderBy(m => m.Name)
           .ToList()
           .ForEach(m => Console.WriteLine(m));

        public void GetExpMages(int level) => this.Where(m => m.Level > level)
            .OrderBy(m => m.Level)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetTalentedMages(int level) => this.Where(m => m.Inteligence > 20 && level > m.Level)
            .OrderByDescending(m => m.Inteligence)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetCommonPotential() => 
            Console.WriteLine(this.Where(m => m.Level > 2 && m.Dextirity > 10)
             .Sum(m => m.MaxMP));

        public void GetMagesSpells(int value) => this.Where(m => m.SpellBook.Count >= value)
            .OrderByDescending(m => m.SpellBook.Count)
            .Select(m => new
            {
                m.Name,
                m.SpellBook.Count,
                m.MaxHP
            }).ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetTheBestMages() => this.Select(m => new
        {
            m.Name,
            m.Level,
            average = (m.Strength + m.Dextirity + m.Inteligence) / 3
        }).OrderByDescending(m => m.average)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetMageGreatestSpells() => 
            Console.WriteLine(this.Where(m => m.SpellBook.Count.Equals(this.Max(max => max.SpellBook.Count))).ElementAt(0));

        public void GetAllSpells() => this.SelectMany(m => m.SpellBook)
            .Distinct()
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetAllSpellsOfOneType(SpellType spellType) => this.SelectMany(m => m.SpellBook)
            .Where(m => m.SpellType.Equals(spellType))
            .Distinct()
            .ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetAllSpellsOfOneTypeAndOneMage(SpellType spellType, string name)
        {
            var temp = this.Single(m => m.Name.Equals(name))
            .SpellBook.Where(m => m.SpellType.Equals(spellType));
            
            foreach(var m in temp) 
            {
                Console.WriteLine(m);
            }
        }

        public void GetNumberOfSpellsAllTypes() => this.SelectMany(m => m.SpellBook)
            .Distinct()
            .GroupBy(s => s.SpellType)
            .Select(s => new
            {
                s.Key,
                Count = s.Count()
            }).ToList()
            .ForEach(s => Console.WriteLine($"{s.Key} ==> {s.Count}"));

        public void GetNumberOfSpellsAllTypesOneMage(string name) => this.Single(m => m.Name.Equals(name))
            .SpellBook
            .Distinct()
            .GroupBy(s => s.SpellType)
            .Select(s => new
            {
                s.Key,
                Count = s.Count()
            }).ToList()
            .ForEach(s => Console.WriteLine($"{s.Key} ==> {s.Count}"));

        public void GetTheBestMagesWithoutGandalf() => this.OrderByDescending(m => m.Level)
            .Skip(1)
            .Take(2)
            .Select(m => new
            {
                m.Name,
                m.Level
            }).ToList()
            .ForEach(m => Console.WriteLine(m));

        public void GetAllReady()
        {
            if (this.All(m => m.HP.Equals(m.MaxHP) && m.MP.Equals(m.MaxMP)))
            {
                Console.WriteLine("Gotowni!");
            }
            else
            {
                Console.WriteLine("Nie gotowi!");
            }   
        }

        public void isDead()
        {
            if(this.Any(m => m.HP.Equals(0)))
            {
                Console.WriteLine("Na pewno co najmniej jedna osoba umarła");
            }
        }

        public void SpecialMission() => this.Select(m => new
        {
            m.Name,
            m.Level,
            m.FireResistance,
            m.IceResistance,
            m.PoisonResistance,
            average = (m.IceResistance + m.FireResistance + m.PoisonResistance) / 3
        }).OrderByDescending(m => m.Level)
            .Take(3)
            .ToList()
            .ForEach(m => Console.WriteLine(m));

    }
}
