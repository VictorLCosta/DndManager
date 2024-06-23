namespace Domain.Entities;

public class ClassLevel : BaseEntity
{
    public string Index { get; set; } = string.Empty;
    public int Level { get; set; }
    public int AbilityScoreBonuses { get; set; }
    public int ProficiencyBonus { get; set; }

    public Guid ClassId { get; set; }
    public DndClass DndClass { get; set; } = null!;

    public ICollection<Feature> Features { get; set; } = [];
}
