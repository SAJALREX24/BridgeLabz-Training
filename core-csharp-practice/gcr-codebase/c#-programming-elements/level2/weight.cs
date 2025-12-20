using System;

class Random
{
    public static void Main(string[] args)
    {
        //Reading weight in pounds
        Console.Write("Enter weight in pounds");
        double pounds = Convert.ToDouble(Console.ReadLine());

        //Converting pounds to kilograms
        double kilograms = pounds / 2.2;

        //Displaying result
        Console.WriteLine("The weight of the person in pounds is "+pounds+" and in kg is "+kilograms);
    }
}
