using System;
using System.Collections.Generic;
using System.Text;

namespace lab08lib
{
    public class Mage
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Strength { get; set; }
        public int Dextirity { get; set; }
        public int Inteligence { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int MP { get; set; }
        public int MaxMP { get; set; }
        public int Damage { get; set; }
        public int PhysicalResistance { get; set; }
        public int FireResistance { get; set; }
        public int IceResistance { get; set; }
        public int PoisonResistance { get; set; }

        public SpellBook SpellBook { get; set; }

        public override string ToString()
        {
            return $"{Name }, Hp {HP}/{MaxHP}, MP {MP}/{MaxMP}, Lvl {Level}, Exp {Experience}, Str {Strength}, Dex {Dextirity}, Int {Inteligence}, Dmg {Damage}, Res [Physical {PhysicalResistance}, FIre {FireResistance}, Ice {IceResistance}, Poison {PoisonResistance}] \n{SpellBook}";

        }
    }
}
