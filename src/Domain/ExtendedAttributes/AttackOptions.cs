namespace Domain.ExtendedAttributes;

public class AttackOptions
{
    public int Choose { get; set; }
    public string Type { get; set; } = string.Empty;

    public From From { get; set; } = null!;
}
