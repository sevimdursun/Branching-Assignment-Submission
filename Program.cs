
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ExecuteShippingLogic();
        }
        catch (Exception error)
        {
            Console.WriteLine($"An error occurred: {error.Message}");
        }
    }

    static void ExecuteShippingLogic()
    {
        Console.WriteLine("Starting Package Express service. Please follow the steps below carefully.");

        decimal weight = GetInput("Please enter the package weight:");
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        decimal width = GetInput("Please enter the package width:");
        decimal height = GetInput("Please enter the package height:");
        decimal length = GetInput("Please enter the package length:");

        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        decimal quote = (width * height * length * weight) / 100;
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Many thanks!");
    }

    static decimal GetInput(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            if (decimal.TryParse(Console.ReadLine(), out decimal number) && number > 0)
                return number;

            Console.WriteLine("Invalid input. Enter a positive numeric value.");
        }
    }
}
