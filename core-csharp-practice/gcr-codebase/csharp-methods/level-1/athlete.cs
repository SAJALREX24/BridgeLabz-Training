using System;

class Random
{
    // Method to calculate rounds
    public static double Calrounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
		double totalDistance = 5000;
        double rounds = totalDistance / perimeter;
        return rounds;
    }

    static void Main()
    {
        // User Input
        Console.Write("Enter side 1");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3");
        double side3 = Convert.ToDouble(Console.ReadLine());

        // Method call
        double result = Calrounds(side1, side2, side3);

        // Output
        Console.WriteLine("Number of rounds required" + result);
    }
}
