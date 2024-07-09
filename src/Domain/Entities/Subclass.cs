namespace Domain.Entities;

public class Subclass : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string SubclassFlavor { get; set; } = string.Empty;

    public Guid ClassId { get; set; }
    public DndClass Class { get; set; } =  null!;

    public ICollection<SubclassSpell> Spells { get; set; } = [];
}
