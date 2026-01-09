using System;

class Random
{
     // Convert kilometers to miles
    public static double ConvertKmToMiles(double kmValue)
    {
        return kmValue * 0.621371;
    }

    // Convert miles to kilometers
    public static double ConvertMilesToKm(double milesValue)
    {
        return milesValue * 1.60934;
    }

    // Convert meters to feet
    public static double ConvertMetersToFeet(double metersValue)
    {
        return metersValue * 3.28084;
    }

    // Convert feet to meters
    public static double ConvertFeetToMeters(double feetValue)
    {
        return feetValue * 0.3048;
    }

    static void Main()
    {
        // Input values
        Console.Write("Enter distance in kilometers ");
        double kmValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter distance in miles ");
        double milesValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter length in meters ");
        double metersValue = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter length in feet ");
        double feetValue = Convert.ToDouble(Console.ReadLine());

        // Method calling 
        Console.WriteLine("Kilometers to Miles " + ConvertKmToMiles(kmValue));
        Console.WriteLine("Miles to Kilometers " + ConvertMilesToKm(milesValue));
        Console.WriteLine("Meters to Feet " + ConvertMetersToFeet(metersValue));
        Console.WriteLine("Feet to Meters " + ConvertFeetToMeters(feetValue));
    }
}
