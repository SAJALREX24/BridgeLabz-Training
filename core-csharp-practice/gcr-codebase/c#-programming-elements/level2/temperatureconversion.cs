using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading temperature in Celsius
        Console.Write("Enter temperature in Celsius");
        double celsius = Convert.ToDouble(Console.ReadLine());

        //Converting Celsius to Fahrenheit using formula
        double fahrenheitResult = (celsius * 9 / 5) + 32;

        //Displaying result
        Console.WriteLine("The "+celsius+" Celsius is "+fahrenheitResult+" Fahrenheit");
    }
}
