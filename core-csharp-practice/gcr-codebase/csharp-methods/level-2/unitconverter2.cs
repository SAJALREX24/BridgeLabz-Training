using System;

class Random
{
    // Convert yards to feet
    public static double ConvertYardsToFeet(double yardsValue)
    {
        return yardsValue * 3;
    }

    // Convert feet to yards
    public static double ConvertFeetToYards(double feetValue)
    {
        return feetValue * 0.333333;
    }

    // Convert meters to inches
    public static double ConvertMetersToInches(double metersValue)
    {
        return metersValue * 39.3701;
    }

    // Convert inches to meters
    public static double ConvertInchesToMeters(double inchesValue)
    {
        return inchesValue * 0.0254;
    }

    // Convert inches to centimeters
    public static double ConvertInchesToCm(double inchesValue)
    {
        return inchesValue * 2.54;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter value in yards ");
        double yardsValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value in feet ");
        double feetValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value in meters ");
        double metersValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter value in inches ");
        double inchesValue = Convert.ToDouble(Console.ReadLine());

        // Output
        Console.WriteLine("Yards to Feet " + ConvertYardsToFeet(yardsValue));
        Console.WriteLine("Feet to Yards " + ConvertFeetToYards(feetValue));
        Console.WriteLine("Meters to Inches " + ConvertMetersToInches(metersValue));
        Console.WriteLine("Inches to Meters " + ConvertInchesToMeters(inchesValue));
        Console.WriteLine("Inches to Centimeters " + ConvertInchesToCm(inchesValue));
    }
}
