using System;

class Random
{
    
    public static double CalculatePercentage(double totalMarks)
    {
        return Math.Round((totalMarks / 300) * 100, 2);
    }

    static void Main()
    {
       
        Console.Write("Enter Total Marks (out of 300)");
        double totalMarks = Convert.ToDouble(Console.ReadLine());

       
        double percentage = CalculatePercentage(totalMarks);
        Console.WriteLine("Percentage Obtained: " + percentage + "%");
    }
}
