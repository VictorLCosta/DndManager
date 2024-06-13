namespace DndManager.Core.Domain.ValueObjects;

public class Currency : ValueObject
{
    public Currency(string name, string symbol)
    {
        Name = name;
        Symbol = symbol;
    }

    public string Name { get; init; }
    public string Symbol { get; init; }

    private static readonly IDictionary<string, Currency> _currencies;
    
    static Currency()
    {
        _currencies = new Dictionary<string, Currency>()
        {
            { Platinum.Name, Platinum },
            { Gold.Symbol, Gold },
            { Electrum.Name, Electrum },
            { Silver.Name, Silver},
            { Copper.Name, Copper }
        };
    }

    public override string ToString() => Symbol;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Symbol;
    }

    public static Currency FromCode(string code)
    {
        return string.IsNullOrWhiteSpace(code)
            ? throw new ArgumentNullException(nameof(code))
            : !_currencies.ContainsKey(code) ? throw new UnsupportedCurrencyException(code) : _currencies[code];
    }

    public static Currency Platinum => new("Platinum", "pp");
    public static Currency Gold => new("Gold", "gp");
    public static Currency Electrum => new("Electrum", "ep");
    public static Currency Silver => new("Silver", "sp");
    public static Currency Copper => new("Copper", "cp");
}
