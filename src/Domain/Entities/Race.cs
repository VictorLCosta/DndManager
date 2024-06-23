namespace Domain.Entities;

public class Race : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int Speed { get; set; }
    public Size Size { get; set; }
    public string SizeDescription { get; set; } = string.Empty;

    public ICollection<Proficiency> StartingProficiencies { get; set; } = [];
    public ICollection<Language> Languages { get; set; } = [];

    public ICollection<Trait> Traits { get; set; } = [];

    public ICollection<Subrace> Subraces { get; set; } = [];
}
