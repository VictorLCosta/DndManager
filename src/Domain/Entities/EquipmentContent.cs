namespace Domain.Entities;

public class EquipmentContent
{
    public Guid EquipmentId { get; set; }
    public Equipment Equipment { get; set; } = null!;

    public int Quantity { get; set; }
}
