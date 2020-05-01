namespace lab07
{
    public interface ISpellCastable
    {
        int ActualManaPoints { get; set; }
        int MaxManaPoints { get; set; }
        int CastSpell(int manaPoints);
    }
}