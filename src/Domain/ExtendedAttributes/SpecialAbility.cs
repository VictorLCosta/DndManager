namespace Domain.ExtendedAttributes;

public class SpecialAbility
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Usage? Usage { get; set; }

    public Damage[] Damages { get; set; } = [];
    public int AttackBonus { get; set; }

    public Spellcasting? Spellcasting { get; set; }
    public DifficultyClass? DifficultyClass { get; set; }
}
