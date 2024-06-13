namespace DndManager.Core.Common.Exceptions;

public class UnsupportedCurrencyException(string currency) : 
    Exception($"The currency \"{currency}\" is not supported for this system. You must choose between BRL (Brazilian Real), EUR (Euro) and USD (US Dollar).")
{
}
