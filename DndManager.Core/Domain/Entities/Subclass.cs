namespace DndManager.Core.Domain.Entities;

public class Subclass : BaseEntity
{
    public string Description { get; set; } = string.Empty;

    public Guid MainClassId { get; set; }
    public DndClass MainClass { get; set; } = null!;
}
