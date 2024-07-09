namespace Domain.ExtendedAttributes;

public class DifficultyClass(int value, AbilityScore abilityScore, SuccessType successType)
{
    public int Value { get; } = value;
    public AbilityScore AbilityScore { get; } = abilityScore;
    public SuccessType SuccessType { get; } = successType;
}
