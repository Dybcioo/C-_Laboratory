using System;
using System.Collections.Generic;
using System.Text;

namespace lab08lib
{
    public class Spell : IEquatable<Spell>
    {
        public string Name { get; set; }
        public SpellType SpellType { get; set; }
        public int Cost { get; set; }
        public int Cooldown { get; set; }
        public int Effect { get; set; }

        public bool Equals(Spell other) => Name.Equals(other.Name);

        public override string ToString() => $"Nazwa: {Name}, Typ czaru: {SpellType}, Koszt: {Cost}, Ostudzanie: {Cooldown}, Efekt: {Effect}";

        public override bool Equals(object obj) => base.ToString().Equals(obj.ToString());

        public override int GetHashCode() => base.ToString().GetHashCode();
    }

    public enum SpellType
    {
        offensive,
        defensive,
        restorative
    }
}
