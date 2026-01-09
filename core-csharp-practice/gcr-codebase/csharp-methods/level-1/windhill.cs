using System;

class Random
{
    public static double Calculatingwind(double temperature, double windSpeed)
    {
        double wind = 35.74 + 0.6215 * temperature +
                          (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return wind;
    }

    static void Main()
    {
        // Inputs
        Console.Write("Enter temperature");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        // Method call
        double result = Calculatingwind(temperature, windSpeed);

        // Output
        Console.WriteLine("Wind Chill Temperature " + result);
    }
}
