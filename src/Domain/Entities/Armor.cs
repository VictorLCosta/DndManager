namespace Domain.Entities;

public class Armor : Equipment
{
    public ArmorCategory ArmorCategory { get; set; }
    public int MinimumStrength { get; set; }
    public bool StealthDisavantage { get; set; }

    public required ArmorClass ArmorClass { get; set; }
}
