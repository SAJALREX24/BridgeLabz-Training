using System;

class Random
{
    public static double[] Calculating(double angle)
    {
        
        double radians = angle * Math.PI / 180;

        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Method calling
        double[] result = Calculating(angle);

        // Displaying Output
        Console.WriteLine("Sine " + result[0]);
        Console.WriteLine("Cosine " + result[1]);
        Console.WriteLine("Tangent " + result[2]);
    }
}
