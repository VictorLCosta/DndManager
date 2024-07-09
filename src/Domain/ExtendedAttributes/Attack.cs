namespace Domain.ExtendedAttributes;

public class Attack
{
    public string Name { get; set; } = string.Empty;
    public DifficultyClass? DifficultyClass { get; set; }
    public Damage[] Damages { get; set; } = [];
}
