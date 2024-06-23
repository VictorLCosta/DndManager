namespace Domain.Entities;

public class Subrace : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public Guid RaceId { get; set;}
    public Race Race { get; set; } = null!;

    public ICollection<Proficiency> StartingProficiencies { get; set; } = [];
    public ICollection<Language> Languages { get; set; } = [];
    public ICollection<Trait> RacialTraits { get; set; } = [];
}
