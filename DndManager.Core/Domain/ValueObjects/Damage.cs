namespace DndManager.Core.Domain.ValueObjects;

public class Damage(int quantity, Dice dice, DamageType damageType, int? modifier = null) : ValueObject
{
    private readonly Dice _dice = dice;
    private readonly int _quantity = quantity;
    private readonly DamageType _damageType = damageType;
    private readonly int? _modifier = modifier;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _quantity;
        yield return _dice;
        yield return _damageType;
        yield return _modifier ?? 0;
    }

    public override string ToString() => $"{_quantity}{nameof(_dice).ToLower()}{(_modifier.HasValue ? $"+{_modifier}" : string.Empty)} {nameof(_damageType)}";

}
