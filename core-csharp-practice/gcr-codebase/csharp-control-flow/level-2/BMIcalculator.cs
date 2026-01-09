using System;

class Random
{
    static void Main(string[] args)
    {
        // User Input 
        Console.WriteLine("Enter weight in kg");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height in cm");
        double height = double.Parse(Console.ReadLine());

        // Converting height to meters
        height = height / 100;

        // Calculating BMI
        double bmi = weight / (height * height);

        // Displaying BMI
        Console.WriteLine("BMI is "+bmi);
    }
}
