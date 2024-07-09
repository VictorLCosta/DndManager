namespace Domain.ValueObjects;

public class Damage(Dice dice, DamageType damageType) : ValueObject
{
    public Dice Dice { get; } = dice;
    public DamageType DamageType { get; } = damageType;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Dice;
        yield return DamageType;
    }

    public override string ToString() => $"{Dice} {nameof(DamageType).ToLower()}";
}
