using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading temperature in Fahrenheit
        Console.Write("Enter temperature in Fahrenheit");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        //Convert Fahrenheit to Celsius 
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        //Displaying results
        Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsiusResult+" Celsius");
    }
}
