namespace Domain.ExtendedAttributes;

public class GenericOptions<TKey>
{
    public int Choose { get; set; }
    public string Type { get; set; } = string.Empty;

    public TKey[] Options { get; set; } = [];
}
