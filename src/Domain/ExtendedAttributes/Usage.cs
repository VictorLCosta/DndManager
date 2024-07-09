namespace Domain.ExtendedAttributes;

public class Usage
{
    public UsageType UsageType { get; set; }
    public int Times { get; set; }

    public int? MinValue { get; set; }
    public Dice? Dice { get; set; }

    public string[] RestTypes { get; set; } = [];
}
