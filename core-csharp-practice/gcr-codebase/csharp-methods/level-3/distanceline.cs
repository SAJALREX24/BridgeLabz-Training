using System;

class Random
{
    
    public static double FindDistance(double x1Value, double y1Value,double x2Value, double y2Value)
    {
        
        return Math.Sqrt(Math.Pow(x2Value - x1Value, 2) +Math.Pow(y2Value - y1Value, 2));
    }
    public static double[] FindLineEquation(double x1Value, double y1Value,double x2Value, double y2Value)
    {
        
        double slopeValue = (y2Value - y1Value) / (x2Value - x1Value);
		double interceptValue = y1Value - slopeValue * x1Value;
		return new double[] { slopeValue, interceptValue };
    }

    static void Main()
    {
        // Input coordinates
        Console.Write("Enter x1");
        double x1Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1");
        double y1Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2");
        double x2Value = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2");
        double y2Value = Convert.ToDouble(Console.ReadLine());

        double distanceValue = FindDistance(x1Value, y1Value, x2Value, y2Value);

        // Find line equation
        double[] lineResultArray = FindLineEquation(x1Value, y1Value, x2Value, y2Value);

        // Output results
        Console.WriteLine("Distance between points: " + distanceValue);
        Console.WriteLine("Line Equation: y = " + lineResultArray[0] +
                          "x + " + lineResultArray[1]);
    }
}
