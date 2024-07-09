namespace Domain.Entities;

public class Monster : Creature
{
    public double ChallengeRating { get; set; }
    public uint ExperiencePoints { get; set; }

    public ICollection<DamageType> DamageVulnerabilities { get; set; } = [];
    public ICollection<DamageType> DamageResistances { get; set; } = [];
    public ICollection<DamageType> DamageImmunities { get; set; } = [];
    public ICollection<Condition> ConditionImmunities { get; set; } = [];

    public ICollection<MonsterProficiency> Proficiencies { get; set; } = [];

    public ICollection<SpecialAbility> SpecialAbilities { get; set; } = [];
    public ICollection<ExtendedAttributes.Action> Actions { get; set; } = [];
    public ICollection<LegendaryAction> LegendaryActions { get; set; } = [];
    public ICollection<Reaction> Reactions { get; set; } = [];
}
