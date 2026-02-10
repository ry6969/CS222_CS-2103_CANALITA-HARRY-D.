Console.Write("Enter the amount in USD: ");
double amountInUSD = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter exchange rate USD to EUR: ");
double exchangeRate = Convert.ToDouble(Console.ReadLine());
double amountInEUR = amountInUSD * exchangeRate;
Console.WriteLine($"Amount in EUR: {amountInEUR:F2}");

