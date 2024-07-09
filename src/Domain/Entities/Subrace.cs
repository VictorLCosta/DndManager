namespace Domain.Entities;

public class SubRace : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<AbilityBonus> AbilityBonuses { get; set; } = [];

    public GenericOptions<Guid>? AbilityBonusOptions { get; set; }
    public GenericOptions<Guid>? LanguageOptions { get; set; }
    public GenericOptions<Guid>? ProficiencyOptions { get; set; }

    public ICollection<Proficiency> StartingProficiencies { get; set; } = [];
    public ICollection<Language> Languages { get; set; } = [];
    public ICollection<Trait> Traits { get; set; } = [];

    public Guid RaceId { get; set; }
    public Race Race { get; set; } = null!;
}
