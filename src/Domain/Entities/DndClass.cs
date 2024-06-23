namespace Domain.Entities;

public class DndClass : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int HitDie { get; set; }

    public ICollection<Subclass> Subclasses { get; set; } = [];
    public ICollection<ClassLevel> Levels { get; set; } = [];
    public ICollection<Equipment> StartingEquipments { get; set; } = [];
    public ICollection<Proficiency> Proficiencies { get; set; } = [];
}
