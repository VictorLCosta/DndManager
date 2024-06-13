namespace DndManager.Core.Domain.Entities;

public class Feature : BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public int Level { get; set; }

    public Guid DndClassId { get; set; }
    public required DndClass DndClass { get; set; }

    public Guid? SubClassId { get; set; }
    public Subclass? SubClass { get; set; }

    public Feature? ParentFeature { get; set; }
}
