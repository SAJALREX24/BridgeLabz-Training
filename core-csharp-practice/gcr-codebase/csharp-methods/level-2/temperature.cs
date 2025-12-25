using System;

class Random
{
    // Convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius(double fahrenheitValue)
    {
        return (fahrenheitValue - 32) * 5 / 9;
    }

    // Convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit(double celsiusValue)
    {
        return (celsiusValue * 9 / 5) + 32;
    }

    // Convert pounds to kilograms
    public static double ConvertPoundsToKg(double poundsValue)
    {
        return poundsValue * 0.453592;
    }

    // Convert kilograms to pounds
    public static double ConvertKgToPounds(double kgValue)
    {
        return kgValue * 2.20462;
    }

    // Convert gallons to liters
    public static double ConvertGallonsToLiters(double gallonsValue)
    {
        return gallonsValue * 3.78541;
    }

    // Convert liters to gallons
    public static double ConvertLitersToGallons(double litersValue)
    {
        return litersValue * 0.264172;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter temperature in Fahrenheit ");
        double fahrenheitValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter temperature in Celsius ");
        double celsiusValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter weight in pounds ");
        double poundsValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter weight in kilograms ");
        double kgValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter volume in gallons ");
        double gallonsValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter volume in liters ");
        double litersValue = Convert.ToDouble(Console.ReadLine());

        // Output
        Console.WriteLine("Fahrenheit to Celsius " + ConvertFahrenheitToCelsius(fahrenheitValue));
        Console.WriteLine("Celsius to Fahrenheit " + ConvertCelsiusToFahrenheit(celsiusValue));
        Console.WriteLine("Pounds to Kilograms " + ConvertPoundsToKg(poundsValue));
        Console.WriteLine("Kilograms to Pounds " + ConvertKgToPounds(kgValue));
        Console.WriteLine("Gallons to Liters " + ConvertGallonsToLiters(gallonsValue));
        Console.WriteLine("Liters to Gallons " + ConvertLitersToGallons(litersValue));
    }
}
