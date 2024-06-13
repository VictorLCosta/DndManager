namespace DndManager.Core.Domain.Entities;

public class Trait : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Race> Races { get; set; } = [];

    public ICollection<Proficiency> Proficiencies { get; set; } = [];    
}
