
namespace Domain.ValueObjects;

public class AreaOfEffect(AreaOfEffectType type, int size) : ValueObject
{
    public AreaOfEffectType Type { get; } = type;
    public int Size { get; } = size;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Type;
        yield return Size;
    }
}
