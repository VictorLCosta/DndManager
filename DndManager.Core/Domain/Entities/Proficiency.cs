namespace DndManager.Core.Domain.Entities;

public class Proficiency : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public ProficiencyType ProficiencyType { get; set; }

    public ICollection<DndClass> DndClasses { get; set; } = [];
    public ICollection<Race> Races { get; set; } = [];
}
