namespace Domain.Entities;

public class ClassLevel : BaseEntity
{
    public int Level { get; set; }
    public int AbilityScoreBonuses { get; set; }
    public int ProficiencyBonus { get; set; }

    public ClassSpecific? ClassSpecific { get; set; }
    
    public ICollection<Feature> Features { get; set; } = [];

    public DndClass Class { get; set; } = null!;

    public DndClassSpellcasting? Spellcasting { get; set; }
}
