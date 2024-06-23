namespace Domain.ValueObjects;

public class ArmorClass : ValueObject
{
    public ArmorClass()
    {
        
    }

    public int BaseValue { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return BaseValue;
    }
}
