namespace Domain.ExtendedAttributes;

public class LegendaryAction
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public int AttackBonus { get; set; }
    public Damage[] Damage { get; set; } = [];

    public DifficultyClass? DifficultyClass { get; set; }
}
