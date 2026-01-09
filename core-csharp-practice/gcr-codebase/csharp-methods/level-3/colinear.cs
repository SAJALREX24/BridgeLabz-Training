using System;

class Random
{
    // Method to check whether three points are collinear
    public static bool AreCollinear(double x1Value, double y1Value,double x2Value, double y2Value,double x3Value, double y3Value)
    {
        double areaValue = 0.5 * (x1Value * (y2Value - y3Value) +x2Value * (y3Value - y1Value) +x3Value * (y1Value - y2Value));

        return areaValue == 0;
    }

    static void Main()
    {
        // Input coordinates of first point
        Console.Write("Enter x1");
        double x1Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1");
        double y1Value = Convert.ToDouble(Console.ReadLine());

        // Input coordinates of second point
        Console.Write("Enter x2");
        double x2Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2");
        double y2Value = Convert.ToDouble(Console.ReadLine());

        // Input coordinates of third point
        Console.Write("Enter x3");
        double x3Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y3");
        double y3Value = Convert.ToDouble(Console.ReadLine());

        // Check collinearity
        if (AreCollinear(x1Value, y1Value, x2Value, y2Value, x3Value, y3Value))
            Console.WriteLine("points are Collinear");
        else
            Console.WriteLine("points are NOT Collinear");
    }
}
