using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public delegate void Delegate(int arg);
    public partial class Dragon : Character, ISpellCastable
    {
        public event Delegate OnDone;

        public int ActualManaPoints { get; set ; }
        public int MaxManaPoints { get; set; }

        public int CastSpell(int manaPoints)
        {
            return 0;
        }



        public override void LevelUp()
        {
            Level += 1;
            Strength += 10;
            Intelligence += 1;
            Agility += 5;
        }

        public void Fire()
        {
            int fireStrange = Damage * new Random().Next(5);
            PartialMethod();
            Console.WriteLine($"{Name} zioną ogniem o intensywnosci {fireStrange}");
            OnDone?.Invoke(fireStrange);
        }  
    }
}
