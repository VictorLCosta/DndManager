namespace Domain.Entities;

public class Race : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int Speed { get; set; }
    public string Alignment { get; set; } = string.Empty;
    public string Age { get; set; } = string.Empty;
    public Size Size { get; set; }
    public string SizeDescription { get; set; } = string.Empty;

    public ICollection<AbilityBonus> AbilityBonuses { get; set; } = [];

    public GenericOptions<Guid>? AbilityBonusOptions { get; set; }
    public GenericOptions<Guid>? LanguageOptions { get; set; }
    public GenericOptions<Guid>? ProficiencyOptions { get; set; }

    public ICollection<Proficiency> StartingProficiencies { get; set; } = [];
    public ICollection<Language> Languages { get; set; } = [];
    public ICollection<Trait> Traits { get; set; } = [];
    public ICollection<SubRace> SubRaces { get; set; } = [];
}
