namespace Domain.Entities;

public class DndClass : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int HitDie { get; set; }

    public GenericOptions<Guid> ProficiencyOptions { get; set; } = null!;

    public ICollection<Proficiency> Proficiencies { get; set; } = [];
    public ICollection<AbilityScore> SavingThrows { get; set; } = [];

    public ICollection<Subclass> Subclasses { get; set; } = [];

    public ICollection<ClassEquipment> StartingEquipment { get; set; } = [];

    public ICollection<ClassLevel> ClassLevels { get; set; } = [];

    public Multiclassing? Multiclassing { get; set; }

    public StartingEquipmentOptions? StartingEquipmentOptions { get; set; }

    public ClassSpellcasting? Spellcasting { get; set; }

    public ICollection<Spell> Spells { get; set; } = [];
}
