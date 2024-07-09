namespace Domain.ExtendedAttributes;

public class SpellcastingSpell
{
    public string Name { get; set; } = string.Empty;
    public int Level { get; set; }
    public string Notes { get; set; } = string.Empty;
    public Guid SpellId { get; set; }

    public Usage? Usage { get; set; }
}
