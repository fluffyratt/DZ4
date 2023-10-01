// Task 3
using System;

class Converter
{
    private decimal _usdToUah;
    private decimal _eurToUah;

    public Converter(decimal usdToUah, decimal eurToUah)
    {
        this._usdToUah = usdToUah;
        this._eurToUah = eurToUah;
    }

    public decimal ConvertFromUahToUsd(decimal amount)
    {
        return amount / _usdToUah;
    }

    public decimal ConvertFromUahToEur(decimal amount)
    {
        return amount / _eurToUah;
    }

    public decimal ConvertToUahFromUsd(decimal amount)
    {
        return amount * _usdToUah;
    }

    public decimal ConvertToUahFromEur(decimal amount)
    {
        return amount * _eurToUah;
    }
}

class Program
{
    static void Main()
    {
        Converter converter = new Converter(36.9m, 39m); 

        Console.Write("Input the sum: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        Console.Write("Choose currency (USD або EUR): ");
        string currency = Console.ReadLine().ToUpper();

        decimal convertedAmount = 0;

        switch (currency)
        {
            case "USD":
                convertedAmount = converter.ConvertFromUahToUsd(amount);
                Console.WriteLine($"Sum in USD: {convertedAmount}");
                break;
            case "EUR":
                convertedAmount = converter.ConvertFromUahToEur(amount);
                Console.WriteLine($"Sum in EUR: {convertedAmount}");
                break;
            default:
                Console.WriteLine("The selected currency is not supported.");
                break;
        }

        Console.Write("Select the currency to convert to UAH (USD або EUR): ");
        string toCurrency = Console.ReadLine().ToUpper();

        switch (toCurrency)
        {
            case "USD":
                convertedAmount = converter.ConvertToUahFromUsd(amount);
                Console.WriteLine($"Sum in UAH: {convertedAmount}");
                break;
            case "EUR":
                convertedAmount = converter.ConvertToUahFromEur(amount);
                Console.WriteLine($"Sum in UAH: {convertedAmount}");
                break;
            default:
                Console.WriteLine("The selected currency is not supported.");
                break;
        }
    }
}
