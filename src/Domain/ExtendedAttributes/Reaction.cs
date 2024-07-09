namespace Domain.ExtendedAttributes;

public class Reaction
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public DifficultyClass? DifficultyClass { get; set; }
}
