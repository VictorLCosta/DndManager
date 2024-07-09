namespace Domain.ExtendedAttributes;

public class Form
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid MonsterId { get; set; }
}
