namespace Domain.ExtendedAttributes;

public class From
{
    public string Name { get; set; } = string.Empty;
    public DifficultyClass? DifficultyClass { get; set; }
    public Damage[] Damages { get; set; } = [];
}
