namespace Domain.ValueObjects;

public class Speed : ValueObject
{
    public Speed(double quantity, SpeedUnit unit)
    {
        Quantity = quantity;
        Unit = unit;
    }

    public double Quantity { get; }
    public SpeedUnit Unit { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Quantity;
        yield return Unit;
    }

    public override string ToString() => $"{Quantity} {(Unit == SpeedUnit.FtRound ? "ft." : "mph")}";

    public Speed ToMph() => new (Unit == SpeedUnit.MilesPerHour ? Quantity : Quantity / 8.8, SpeedUnit.MilesPerHour);
    public Speed ToFeetPerRound() => new (Unit == SpeedUnit.FtRound ? Quantity : Quantity * 8.8, SpeedUnit.FtRound);
}
