namespace Domain.ValueObjects;

public class CreatureSpeed(Speed? walk = null, Speed? fly = null, Speed? swim = null, Speed? burrow = null, Speed? climb = null) : ValueObject
{
    public Speed Walk { get; set; } = walk ?? new();
    public Speed Fly { get; set; } = fly ?? new();
    public Speed Swim { get; set; } = swim ?? new();
    public Speed Burrow { get; set; } = burrow ?? new();
    public Speed Climb { get; set; } = climb ?? new();

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Walk;
        yield return Fly;
        yield return Swim;
        yield return Burrow;
        yield return Climb;
    }
}
