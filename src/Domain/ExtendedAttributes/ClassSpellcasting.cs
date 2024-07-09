namespace Domain.ExtendedAttributes;

public class ClassSpellcasting
{
    public int Level { get; set; }
    public AbilityScore SpellcastingAbility { get; set; }
    public Info[] Infos { get; set; } = [];

    public class Info
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
