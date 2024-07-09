namespace Domain.Entities;

public class ClassEquipment : BaseEntity
{
    public int Quantity { get; set; }

    public Guid ClassId { get; set; }
    public DndClass Class { get; set; } = null!;

    public Guid EquipmentId { get; set; }
    public Equipment Equipment { get; set; } = null!;
}
