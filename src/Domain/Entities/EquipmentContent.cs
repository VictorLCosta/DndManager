namespace Domain.Entities;

public class EquipmentContent : BaseEntity
{   
    public Equipment Pack { get; set; } = null!;

    public Guid EquipmentId { get; set; }
    public Equipment Equipment { get; set; } = null!;

    public int Quantity { get; set; }
}
