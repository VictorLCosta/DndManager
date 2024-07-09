namespace Domain.ValueObjects;

public class Money(int quantity, Currency currency) : ValueObject
{
    public int Quantity { get; } = quantity;
    public Currency Currency { get; } = currency ?? throw new ArgumentNullException(nameof(currency));

    private static readonly Dictionary<string, int> rates = new()
    {
        { "pp", 1000 },
        { "gp", 100 },
        { "ep", 50 },
        { "sp", 10 },
        { "cp", 1 }
    }; 

    public override string ToString() => $"{Quantity} {Currency}";

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Quantity;
        yield return Currency;
    }

    private Money ConvertTo(string fromCode, string toCode)
    {
        if (fromCode == toCode) return this;

        if (!rates.ContainsKey(fromCode) || !rates.ContainsKey(toCode))
            throw new UnsupportedCurrencyException($"{fromCode} or {toCode} is not a supported currency.");

        int quantityInCopper = Quantity * rates[fromCode];

        int convertedQuantity = quantityInCopper / rates[toCode];

        Currency targetCurrency = Currency.FromCode(toCode);

        return new Money(convertedQuantity, targetCurrency);
    }

    public Money ToPlatinum() => ConvertTo(Currency.Symbol, "pb");
    public Money ToGold() => ConvertTo(Currency.Symbol, "gp");
    public Money ToElectrum() => ConvertTo(Currency.Symbol, "ep");
    public Money ToSilver() => ConvertTo(Currency.Symbol, "sp");
    public Money ToCopper() => ConvertTo(Currency.Symbol, "cp");
}
