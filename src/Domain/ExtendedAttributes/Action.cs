namespace Domain.ExtendedAttributes;

public class Action
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Usage? Usage { get; set; }

    public int AttackBonus { get; set; }
    public Damage[] Damage { get; set; } = [];

    public DifficultyClass? DifficultyClass { get; set; }

    public Attack[] Attacks { get; set; } = [];
    public AttackOptions[] AttackOptions { get; set; } = [];
}
