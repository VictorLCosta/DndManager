
namespace Domain.ValueObjects;

public class Dice(DiceSide diceSide, int quantity, int? modifier = null) : ValueObject
{
    public DiceSide DiceSide { get; } = diceSide;
    public int Quantity { get; } = quantity;
    public int? Modifier { get; } = modifier;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return DiceSide;
        yield return Quantity;
        yield return Modifier ?? 0;
    }

    public override string ToString() => $"{Quantity}{nameof(DiceSide).ToLower()}{(Modifier.HasValue ? $"+{Modifier}" : string.Empty)}";
}
