using System;
using System.Collections.Generic;
using System.Text;

namespace lab07
{
    public static class CharacterTeam
    {
        public static void DrinkHealthPotion(this Character character) => character.CurrentLifePoints = character.MaxLifePoints;

        public static bool IsDead(this Character character)
        {
            if (character.CurrentLifePoints <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void IncreseExp(this Character character, int exp)
        {
            character.Experience += exp;
            int value = character.Level * 1000;
            while(character.Experience > value)
            {
                exp = character.Experience - value;
                character.LevelUp();
                character.Experience = exp;
                value = character.Level * 1000;
            }
        }

        public static void RegenerateMana(this Mage mage, int mana)
        {
            if (mage.ActualManaPoints + mana > mage.MaxManaPoints)
            {
                mage.ActualManaPoints = mage.MaxManaPoints;
            }
            else
            {
                mage.ActualManaPoints += mana;
            }
        }

        public static void DecreaseDamage(this Character character, int value) => character.Damage -= value;

        public static void DecreaseArmor(this Character character, int value) => character.Resistance -= value;

        public static void Meditation(this ISpellCastable caster) => caster.ActualManaPoints = caster.MaxManaPoints;
    }
}
