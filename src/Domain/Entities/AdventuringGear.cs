namespace Domain.Entities;

public class AdventuringGear : Equipment
{
    public GearCategory GearCategory { get; set; }
    public ICollection<EquipmentContent>? Contents { get; set; }
}
