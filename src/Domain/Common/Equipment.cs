namespace Domain.Common;

public abstract class Equipment : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public double Weight { get; set; }
    public bool IsMagic { get; set; }

    public required Money Cost { get; set; }

    public Rarity Rarity { get; set; }

    public bool Variant { get; set; }
    public Guid? ParentId { get; set; }
    public Equipment? Parent { get; set; }

    public virtual ICollection<Equipment>? Variants { get; set; }
}
